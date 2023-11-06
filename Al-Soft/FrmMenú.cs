using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Al_Soft
{
    public partial class FrmMenú : Form
    {
        #region Libreria para Mover el Formulario.
        public FrmMenú()
        {
            InitializeComponent();
        }
        //😭 Para mover el formulario.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasedCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int Param, int lParam);

        private void pnlCntrlMenú_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasedCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Programación de Vectores
        private void btnSalir_Click(object sender, EventArgs e)
        {
          
            if (MessageBox.Show("¿Desea Cerrar del Programa?", "Alerta ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
             Application.Exit();
        }

        //Creamos variables para capturar la posición del Formulario y así poderlo maximizar y restaurar en un lugar fijo.
        int LX, LY;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size; //indicamos q el tamaño de este form sea del mismo tamaño q el form principal
            this.Location = Screen.PrimaryScreen.WorkingArea.Location; //para q el formulario no ocupe toda la pantalla.
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1250, 750); //indicamos q el tamaño del form tendra un nuevo tamaño, en este caso será el de nuestro form
            this.Location = new Point(LX, LY);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Método para Abrir un único Formulario dentro de otro.
        //Metodo para abrir un único formulario "hijo" dentro del panel contenedor "padre".
        private Form activeForm = null; //cierra el formulario anterior desechando instancias para que el programa no colapse.
        private void AbrirFormularios(Form NuevoForm)
        {
            if (activeForm != null)
                activeForm.Close(); //si exíste algun forulario activo, se lo cierra.

            activeForm = NuevoForm; // guardamos el formulario q se vaya a abrir dentro de uno nuevo.
            NuevoForm.TopLevel = false; // le decimos al programa q el nuevo form no es de nivel superior sino q es un form hijo.
            NuevoForm.FormBorderStyle = FormBorderStyle.None; //quitamos los bordes del formulario.
            NuevoForm.Dock = DockStyle.Fill; // le indicamos que debe rellenar todo el panel contenedor.
            pnlContenedor.Controls.Add(NuevoForm); // agregamos el nuevo form a una lista junto con los demas q irán dentro del pnl contenedor.
            pnlContenedor.Tag = NuevoForm; // asociamos el nuevo formulario al pnl contenedor.
            NuevoForm.BringToFront(); // oculta el logo del formulario contenedor. 
            NuevoForm.Show(); // por último, se muestra el nuevo formulario dentro del panel contenedor.
        }
        #endregion 

        #region Formulario Clientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmClientes());
        }

        #endregion

        #region Formulario Registro Usuario
        private void btnCuentaUsuario_Click(object sender, EventArgs e)
        {      
            AbrirFormularios(new FrmRegistro());
        }
        #endregion

        private void btnStockMP_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmStock_MP());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenú.Width == 360)
            {
                pnlMenú.Width = 60;
            }
            else
            {
                pnlMenú.Width = 360;
            }

        }
    }
}

