using System;
using System.Drawing;
using System.Windows.Forms;

namespace Al_Soft
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        #region Método para abrir formularios dentro de formularios hijos
        private void AbrirFormularios()
        {
          
            FrmBuscarCli fcli = new FrmBuscarCli(); //Invocamos al formulario q queremos abrir.
            AddOwnedForm(fcli); //Indicamos q el frmClientes es propietario de frmNuevoCli.
            fcli.FormBorderStyle = FormBorderStyle.None; //le quitamos el borde a frmNuevoCli.
            fcli.TopLevel = false; //indicamos q dicho form no es de nivel superior.
            fcli.Dock = DockStyle.Fill; // indicamos q su estilo ocupe todo el panel.
            this.Controls.Add(fcli); 
            this.Tag = fcli; 
            fcli.BringToFront(); //se trae al frente a dicho formulario.
            fcli.Show(); // finalmente se lo muestra en la interfaz.
        }
        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Llamamos al metodo para abrir formularios hijos dentro de otro hijo.
            AbrirFormularios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }     
}

