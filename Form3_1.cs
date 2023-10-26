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
using MySqlX.XDevAPI;

namespace Al_Soft
{
    public partial class Form3_1 : Form
    {
        public Form3_1()
        {
            InitializeComponent();
        }
        MySqlConnection Abrirconexion = new MySqlConnection("server=127.0.0.1; database=tienda; Uid=root;");
      

        //Método para ir Actualizando los datos a medida q se agreguen, eliminen o modifiquen en la tabla:
        public void ActualizarTablas()
        {
            string abrirconsulta = "SELECT Nombre, Apellido, Cédula_Cli, Dirección, Teléfono FROM Clientes";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(abrirconsulta, Abrirconexion); //adapta datos a una tabla virtual.
            DataTable tablavirtual = new DataTable();
            adaptador.Fill(tablavirtual);
            dgvClientes.DataSource = tablavirtual;
            Abrirconexion.Close();
        }

        private void Form3_1_Load(object sender, EventArgs e)
        {
            Abrirconexion.Open();
            string abrirconsulta = "SELECT Nombre, Apellido, Cédula_Cli, Dirección, Teléfono FROM Clientes"; //cargo en la consulta la tabla con los atributos q voy a utilizar.
            MySqlDataAdapter adaptador = new MySqlDataAdapter(abrirconsulta, Abrirconexion);
            DataTable tablavirtual = new DataTable();
            adaptador.Fill(tablavirtual);
            dgvClientes.DataSource = tablavirtual;
            Abrirconexion.Close();
        }

        private void btnAñadir_Click(object sender, EventArgs e) //Se traen los datos de las tablas de mysql hacia el programa.
        {
            Abrirconexion.Open(); //Se abre la conexion con mysql
            string nomC = txbNombre.Text;
            string apeC = txbApellido.Text;
            string ciCli = txbCI.Text;
            string dir = txbDir.Text;
            string tel = txbTel.Text;
            string fechsol = dateFechaSolicit.Text;

            string consulta1 = "INSERT INTO Clientes (Nombre, Apellido, Cédula_Cli, Dirección, Teléfono) " +
                "VALUES ('" + nomC + "','" + apeC + "','" + ciCli + "','" + dir + "','" + tel + "');";
            MySqlCommand comando = new MySqlCommand(consulta1, Abrirconexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registrado.");
            ActualizarTablas();
            LimpiarCampos();
            Abrirconexion.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Abrirconexion.Open();
            string consulta = "UPDATE Clientes SET Nombre='" + txbNombre.Text + "', Apellido='" + txbApellido.Text + "'," +
                "Cédula_Cli='" + txbCI.Text + "', Dirección='" + txbDir.Text + "',Teléfono='" + txbTel.Text + "' WHERE  Cédula_Cli='" + txbCI.Text + "'";
            MySqlCommand comando = new MySqlCommand(consulta, Abrirconexion);

            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Modificado.");  
            ActualizarTablas();
            LimpiarCampos();
            Abrirconexion.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
             Abrirconexion.Open();
             string consulta = "DELETE FROM Clientes WHERE Cédula_Cli="+txbCI.Text; //Eliminamos registros.
             MySqlCommand comando = new MySqlCommand(consulta, Abrirconexion);
             comando.ExecuteNonQuery();
             MessageBox.Show("Registro Eliminado.");
             LimpiarCampos();
             ActualizarTablas();
             Abrirconexion.Close();      
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //para que cada textbox se vaya llenando con la fila seleccionada en la tabla del datagridview.
           
            txbNombre.Text = dgvClientes.SelectedCells[0].Value.ToString();
            txbApellido.Text = dgvClientes.SelectedCells[1].Value.ToString();
            txbCI.Text = dgvClientes.SelectedCells[2].Value.ToString();
            txbDir.Text = dgvClientes.SelectedCells[3].Value.ToString();
            txbTel.Text = dgvClientes.SelectedCells[4].Value.ToString();
        }

        public void LimpiarCampos()
        {
            //codigo para limpiar los campos de registro de datos.
            txbNombre.Clear();
            txbApellido.Clear();
            txbCI.Clear();  
            txbDir.Clear(); 
            txbTel.Clear();
        } 
        private void btnBuscar_Click(object sender, EventArgs e)
        {
           Abrirconexion.Open();    

           if (txbBuscador.Text != "")
            {      
                dgvClientes.CurrentCell = null;
                foreach (DataGridViewRow filas in dgvClientes.Rows)
                {
                    filas.Visible = false;
                }
            
                foreach (DataGridViewRow filas in dgvClientes.Rows)
                {
                    foreach (DataGridViewCell celdas in filas.Cells)
                        {
                    if (celdas.Value.ToString().ToUpper().IndexOf(txbBuscador.Text.ToUpper()) == 0)
                        {
                        filas.Visible = true;
                        }
                        break;
                        }

                    }
                }
            }
        }
    }

