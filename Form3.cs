using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Al_Soft
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
         
        }

        //😭 Para mover el formulario.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasedCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int Param, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasedCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cerrar del Programa?", "Alerta ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
       
        int LX, LY;//Creamos variables para que el boton restarurar noabra al formulario solo en un punto fijo
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size; //indicamos q el tamaño de este form sea del mismo tamaño q el form principal
            this.Location = Screen.PrimaryScreen.WorkingArea.Location; //para q el formulario no ocupe toda la pantalla
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1300, 800); //indicamos q el tamaño del form tendra un nuevo tamaño, en este caso será el de nuestro form
            this.Location = new Point(LX, LY);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Form activeForm = null;
        private void AbrirFormularios(Form NuevoForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = NuevoForm;
            NuevoForm.TopLevel = false;
            NuevoForm.FormBorderStyle = FormBorderStyle.None;
            NuevoForm.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(NuevoForm);
            pnlContenedor.Tag = NuevoForm;
            NuevoForm.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new Form3_1());

        }

       
        
        private void btnMoldesP_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new Form3_2());
        }

        private void btnGanancias_Click(object sender, EventArgs e)
        {

        }

        private void pictDeslizarMenu_Click(object sender, EventArgs e)
        {

            if (pnlMenu.Width == 370)
            {
                pnlMenu.Width = 60;
            }
            else
            {
                pnlMenu.Width = 370;
            }
        }
     }
}


