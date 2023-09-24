using MySql.Data.MySqlClient;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Al_Soft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)//si se lo elimina el programa falla xd//
        {
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //Para mover el panel xd
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasedCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int Param, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasedCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Comando para que el usuario pueda ingresar al Formulario siguiente y así Registrarse
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        //Conexión del Programa con la Base de datos de MySQL
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, clave;
            nombre = textBox1.Text;
            clave = textBox2.Text;
            MySqlConnection Abrirconexion = new MySqlConnection("server=127.0.0.1; database=tienda; Uid=root;");
            try
            {
                Abrirconexion.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }

            //Se realiza conexion con la BDD para Iniciar sesion con un usuario y contraseña previamente ingresados. //
            string sql = "select usuario, contraseña from modista where usuario= '" + nombre + "' and contraseña = '" + clave + "' ";
            MySqlCommand codigo = new MySqlCommand(sql, Abrirconexion);
            MySqlDataReader Lectura = codigo.ExecuteReader();

            if (Lectura.Read()) // Se crean 2 condiciones de Inicio de Sesion, donde se leen los datos. //
            {
               //En caso de estar registrado pasa al siguiente formulario
                this.Hide();
                Form3 n3 = new Form3();
                n3.Show();
            }
            else
            {
                MessageBox.Show(" Usuario o Contraseña incorrectos. "); // Se envia un mensaje en caso de error o no estar registrado. //
                this.Hide();
                Form1 n1 = new Form1();
                n1.Show();
            }
        }

        //Ocultar Contraseña
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}