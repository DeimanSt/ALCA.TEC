using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Soft
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //again mover el panel 😒
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasedCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int Param, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasedCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
         MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; database=tienda; Uid=root");
            try
            {
                conexion.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            
            }
            String sql = "insert into modista(usuario,contraseña) values ('" + textBox4.Text + "' , '" + textBox3.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Registrado Exitosamente");
                this.Hide();
                Form1 n1 = new Form1();
                n1.Show();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}