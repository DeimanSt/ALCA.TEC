using Al_Soft.Sistema_Usuarios;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Al_Soft
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            VerContraseña.Checked = false;
            txtContraseña.UseSystemPasswordChar = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasedCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int Param, int lParam);

        private void pnlTituloLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasedCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string Usuario = txtNomUsu.Text;
            string Contras = txtContraseña.Text;

            try
            {
                Manejo_de_Errores ctrl = new Manejo_de_Errores();
                string respuesta = ctrl.cntrlLogin(Usuario, Contras);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    FrmMenú menu = new FrmMenú();
                    menu.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void VerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (VerContraseña.Checked == true)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRecupContraseña frc = new FrmRecupContraseña();
            frc.Show();
            this.Hide();
        }
    }
}
