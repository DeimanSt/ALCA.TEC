using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Soft
{
    public partial class Form3_3 : Form
    {
        public Form3_3()
        {
            InitializeComponent();
        }
        MySqlConnection Abrirconexion = new MySqlConnection("server=127.0.0.1; database=tienda; Uid=root;");

        private void Form3_3_Load(object sender, EventArgs e)
        {

            //cargo en la consulta la tabla con los atributos q voy a utilizar.
            string abrirconsulta = "SELECT*FROM materia_prima";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(abrirconsulta, Abrirconexion);
            DataTable tablavirtual = new DataTable();
            adaptador.Fill(tablavirtual);
            dgvMatPrima.DataSource = tablavirtual;

        }

        public void ActualizarTablas()
        {
            string abrirconsulta = "SELECT*FROM materia_prima";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(abrirconsulta, Abrirconexion); //adapta datos a una tabla virtual.
            DataTable tablavirtual = new DataTable();
            adaptador.Fill(tablavirtual);
            dgvMatPrima.DataSource = tablavirtual;
            Abrirconexion.Close();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Abrirconexion.Open();
            string Descrip = txbDescrip.Text;
            string Cant = txbCantStock.Text;
            string Costo = txbCosto.Text;

            string abrirconsulta = "INSERT INTO materia_prima (Descripción, Cant, Costo) " +
                "values ('" + Descrip + "','" + Cant + "','" + Costo + "');";
            MySqlCommand comando = new MySqlCommand(abrirconsulta, Abrirconexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registrado.");  
            CalculoStock();
            ActualizarTablas();
            LimpiarCampos();
            Abrirconexion.Close();
        }

        public void CalculoStock()
        {         
            string Cant = txbCantStock.Text;
          
            string consulta2= "UPDATE materia_prima SET Stock = Cant + @CantAAgregar WHERE IDMateriaP = @IDMP";
            MySqlCommand comando2 = new MySqlCommand(consulta2, Abrirconexion);
            comando2.Parameters.AddWithValue("@CantAAgregar", Cant);
            comando2.Parameters.AddWithValue("@IDMP",1);

            try
            {
                // Ejecuta la consulta para actualizar el stock del producto
                int resultado = comando2.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Stock actualizado con éxito.");
                }        
            } catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el stock: " + ex.Message);
            }
            finally
            {
                // Cierra la conexión a la base de datos
                Abrirconexion.Close();      
            }
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            Abrirconexion.Open();
            string Descrip = txbDescrip.Text;
            string Cant = txbCantStock.Text;
            string Costo = txbCosto.Text;

            string consulta = "UPDATE materia_prima SET Descripción='" + Descrip + "', Cant='" + Cant + "'," +
                "Costo='" + Costo + "' WHERE IDMateriaP= '" + Descrip + "';";
            MySqlCommand comando = new MySqlCommand(consulta, Abrirconexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Producto Modificado.");
            CalculoStock();
            ActualizarTablas();
            LimpiarCampos();
            Abrirconexion.Close();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Abrirconexion.Open();
            string consulta = "DELETE FROM materia_prima WHERE IDMateriaP=" + txbDescrip.Text; //Eliminamos registros.
            MySqlCommand cmd = new MySqlCommand(consulta, Abrirconexion);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Registro Eliminado.");
            ActualizarTablas();
            LimpiarCampos();
            Abrirconexion.Close();
        }

        public void LimpiarCampos()
        {
            txbDescrip.Clear();
            txbCosto.Clear();
            txbCantStock.Clear();
        } //codigo para limpiar los campos de registro de datos.

        private void dgvMatPrima_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //para que cada textbox se vaya llenando con la fila seleccionada en la tabla del datagridview.
            txbDescrip.Text = dgvMatPrima.SelectedCells[1].Value.ToString();
            txbCantStock.Text = dgvMatPrima.SelectedCells[2].Value.ToString();
            txbCosto.Text = dgvMatPrima.SelectedCells[3].Value.ToString();
        }
    }  
}






