using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Al_Soft
{
    public partial class Form3_1 : Form
    {
        public Form3_1()
        {
            InitializeComponent();
        }
        MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; database=tienda; Uid=root;");
        private void Form3_1_Load(object sender, System.EventArgs e)
        {
          string consulta = "Select*from Clientes";//Cadena de consulta que me va a mostrar los datos de la tabla indicada.
          MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta,conexion);//creo una adaptador que me traiga dichos datos.
          DataTable tabla = new DataTable(); //creamos una tabla virtual que me almacene los datos de la tabl indicada.
                                            //el datatable es una tabla virtual que creamos para mostrar los datos.
          adaptador.Fill(tabla);  
          dataGridCliente.DataSource= tabla; //le indicamos donde queremos que nos muestre los datos, en este caso en el datagridview.

         

        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {

        }
    }
}
