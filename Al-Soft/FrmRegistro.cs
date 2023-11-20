using Al_Soft.Sistema_Usuarios;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Al_Soft
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }
        #region Libreria para Mover el Formulario.
        //😭 Para mover el formulario.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasedCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int Param, int lParam);
        private void FrmRegistro_MouseMove(object sender, MouseEventArgs e)
        {
            ReleasedCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Auxiliares conexauxiliar = new Auxiliares();

            conexauxiliar.Usu1 = txtNomUsu.Text;
            conexauxiliar.Contras1 = txtContras.Text;
            conexauxiliar.ConfirmContras = txtConfContras.Text;
            conexauxiliar.Tel = txtTel.Text;

            conexauxiliar.TipoU = "";

            #region Selección de Tipo de Usuario
            //VALIDAR EL TIPO DE USUARIO A REGISTRAR
            if (radBtnAdmin.Checked == true)
            {
                conexauxiliar.TipoU = "Administrador";
            }
            else
            {
                conexauxiliar.TipoU = "Usuario";
            }
            #endregion Selección de Tipo de Usuario

            try 
            {
                Manejo_de_Errores control = new Manejo_de_Errores(); 
                string respuesta = control.ctrlRegistro(conexauxiliar); 
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Registro Exitoso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    FrmMenú fm = new FrmMenú();
                    fm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }

        }


    }
}

