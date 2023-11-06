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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Auxiliares conexauxiliar = new Auxiliares(); //llamamos a la clase Auxiliares q contiene los métodos de SET y GET.

            // Asignamos a cada SET y GET su correspondiente caja de texto u otra herramienta utilizada (x ej: radiobutton).
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

            try //Convocamos a los Métodos de Captura de Errores.
            {
                Manejo_de_Errores control = new Manejo_de_Errores(); // Convoca al Manejo de Errores para que verifique cada campo.
                string respuesta = control.ctrlRegistro(conexauxiliar); // Carga los valores de cada campo del Formulario de Registro.

                if (respuesta.Length > 0)
                {
                    // En caso de que surga algun error en el registro se envía un mensaje:
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // En caso contrario:
                    MessageBox.Show("Registro Exitoso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                   FrmMenú fm=new FrmMenú();
                    fm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Me envia los Mensajes de error en caso de existir alguno.
            }

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
