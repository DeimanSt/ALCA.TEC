using Al_Soft.Sistema_Usuarios;
using MySql.Data.MySqlClient;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Al_Soft
{
    public partial class FrmRecupContraseña : Form
    {
        public FrmRecupContraseña()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasedCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int Param, int lParam);

        private void pnlVectores_MouseMove(object sender, MouseEventArgs e)
        {
            ReleasedCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin fl = new FrmLogin();
            fl.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string Usuario = txbUsuario.Text;
            string Tel = txbTel.Text;
            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();
            string consulta = "SELECT Usuario, Contraseña, Tel FROM Usuarios";
            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, conex);
                comando.ExecuteNonQuery();

                if (consulta != Tel)
                {
                    MessageBox.Show("El Usuario no existe.");
                }
                else
                {
                    if (consulta == Tel)
                    {
                        MessageBox.Show("La Contraseña es: " + consulta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
