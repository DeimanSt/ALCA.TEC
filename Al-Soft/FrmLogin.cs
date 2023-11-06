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
        }
        #region Código para mover el formulario.
        //😭 Para mover el formulario.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasedCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int Param, int lParam);

        private void pnlTituloLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasedCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion Código para mover el formulario.

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //línea de código que cierra completamente el Programa.
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
                    // En caso de que surga algun error en el registro se envía un mensaje:
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // En caso contrario ingresamos directamente al menú del programa:
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
                txtContraseña.UseSystemPasswordChar = true;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }


    }
}
