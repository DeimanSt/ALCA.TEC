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
using MySql.Data.MySqlClient;

namespace Al_Soft
{
    public partial class Form3_1 : Form
    {
        public Form3_1()
        {
            InitializeComponent();
        }
        MySqlConnection Abrirconexion = new MySqlConnection("server=127.0.0.1; database=tienda; Uid=root;");


        //Método para ir Actualizando los datos que se agreguen, eliminen o modifiquen en la tabla:
        public void ActualizarTablas()
        {
        string abrirconsulta = "select*from Clientes";
        MySqlDataAdapter adaptador = new MySqlDataAdapter(abrirconsulta, Abrirconexion); //adapta datos a una tabla virtual.
        DataTable tablavirtual = new DataTable();
        adaptador.Fill(tablavirtual);
        dgvClientes.DataSource = tablavirtual;
        }
        
        
        private void Form3_1_Load(object sender, EventArgs e)
        {
            Abrirconexion.Open();
           string abrirconsulta = "select*from Clientes";
           MySqlDataAdapter adaptador = new MySqlDataAdapter(abrirconsulta, Abrirconexion);
           DataTable tablavirtual = new DataTable();
           adaptador.Fill(tablavirtual);
           dgvClientes.DataSource = tablavirtual;
           Abrirconexion.Close();

        }

        private void btnAñadir_Click(object sender, EventArgs e) //Se traen los datos de las tablas de mysql hacia el programa.
        {
            Abrirconexion.Open();
            string abrirconsulta = "insert into Clientes (Nombre, Apellido, Cédula_Cli, Dirección, Teléfono) values ('" + txbNombre.Text + "','" + txbApellido.Text + "','"+txbCI.Text+ "','" + txbDir.Text + "','" + txbTel.Text + "');";
            MySqlCommand comando = new MySqlCommand(abrirconsulta, Abrirconexion);
            comando.ExecuteNonQuery();  
            
            MessageBox.Show("Registrado.");

            ActualizarTablas(); 
            Abrirconexion.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Abrirconexion.Open();
             string consulta = "UPDATE Clientes SET Nombre='" + txbNombre.Text + "', Apellido ='" + txbApellido.Text + "', Cédula_Cli='" + txbCI.Text + "', Dirección='" + txbDir.Text + "', Teléfono='" + txbTel.Text;
            MySqlCommand comando = new MySqlCommand(consulta, Abrirconexion);
            comando.ExecuteNonQuery();

            MessageBox.Show("Registro Modificado.");
            
            ActualizarTablas();
            Abrirconexion.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Abrirconexion.Open();
            string consulta = "DELETE FROM Clientes WHERE IDCliente=" + txbIDCliente.Text;
            MySqlCommand comando = new MySqlCommand(consulta, Abrirconexion);
            comando.ExecuteNonQuery();

            MessageBox.Show("Registro Eliminado.");

            ActualizarTablas();
            Abrirconexion.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
