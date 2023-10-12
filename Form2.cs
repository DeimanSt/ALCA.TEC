using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection abrirconexion = new MySqlConnection("server = 127.0.0.1; database=tienda; Uid=root");
            try
            {
                abrirconexion.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.ToString());

            }
            String sql = "insert into Modista(Usuario, Contraseña, Teléfono) values ('"+ IngresarUsuariotxb.Text + "' , '" + Contraseñatxb.Text + "', '" + txbTel.Text + "')";
            MySqlCommand RegistroConex = new MySqlCommand(sql, abrirconexion);
            try
            {
                RegistroConex.ExecuteNonQuery();
                MessageBox.Show("Usuario Registrado Exitosamente");
                this.Hide();
                Form1 n2 = new Form1();
                n2.Show();
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