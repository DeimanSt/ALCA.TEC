using Al_Soft.Sistema_Usuarios;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Al_Soft
{
    public partial class FrmStock_MP : Form
    {
        public FrmStock_MP()
        {
            InitializeComponent();
        }

        private void btnAgregarProd_Click(object sender, System.EventArgs e)
        {
            // Declaramos cada variable.
            string Descrip = txtDescripción.Text;
            int Cant = int.Parse(txtCantidad.Text);
            double Costo = double.Parse(txtCostoXUnid.Text);
            int contador = 0;
            int Stock= contador + Cant;

            // Agregamos nuevos datos ca la tabla selecionada.
            string consulta = "INSERT INTO Materia_prima(Descripción,Cant,Costo,Stock) VALUES('" + Descrip + "','" + Cant + "','" + Costo + "','" + Stock + "')";
            MySqlConnection conex = Conexión.GetConnection(); // Se invoca a la clase conexión.
            conex.Open(); // Se abre la conexión que contiene la clase seleccionada.

            try // Se invoca al caturador de errores.
            {
                MySqlCommand codigo = new MySqlCommand(consulta, conex); // Se envía el codigo de la consulta a la conexion.
                codigo.ExecuteNonQuery();
                MessageBox.Show("Producto Agregado."); // En caso de agregar el producto correctamente aparece este mensaje.
            } catch (MySqlException ex)
            {
                MessageBox.Show("Este Producto no se pudo agregar." + ex.Message, "Error"); // Si surge un error se muestra el mismo.
            }
            finally { conex.Close(); }  //luego de captar y mostrar el error, se cierra la conexión con mysql.
        }

        #region Pasar Datos de la Tabla Materia Prima al DataGridView
        private void FrmStock_MP_Load(object sender, System.EventArgs e)
        {
            string consulta = "SELECT*FROM Materia_prima";
            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();

            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conex);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            TablaMatPrima.DataSource = dt;
        }
        #endregion
    }
}

