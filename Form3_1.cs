using MySql.Data.MySqlClient;
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
         
        private void Form3_1_Load(object sender, EventArgs e)
        {
            //
            string abrirconsulta = "select*from Clientes";
           MySqlDataAdapter adaptador = new MySqlDataAdapter(abrirconsulta, Abrirconexion);
            DataTable tablavirtual = new DataTable();
            adaptador.Fill(tablavirtual);
            dgvClientes.DataSource = tablavirtual;
        }

        private void btnAñadir_Click(object sender, EventArgs e) //Se traen los datos de las tablas de mysql hacia el programa.
        {
            
            Abrirconexion.Open();
            string abrirconsulta = "insert into Clientes (IDCliente, Nombre, Apellido, CédulaC, Dirección, Teléfono) values ('" + txbIDCliente + "','" + txbNombre.Text + "','" + txbApellido.Text + "','"+txbCI.Text+"','" + txbDir.Text + "','" + txbTel.Text + "') ";
            MySqlCommand comando = new MySqlCommand(abrirconsulta, Abrirconexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registrado");

            Abrirconexion.Close();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
