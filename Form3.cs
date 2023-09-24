using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
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

        //😭
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
        private void AbrirFormularios(object NuevoForm)
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = NuevoForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
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
            this.Size = new Size(1200, 700); //indicamos q el tamaño del form tendra un nuevo tamaño, en este caso será el de nuestro form
            this.Location = new Point(LX, LY);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new Form3_1());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new Form3_2());
        }

        private void btnMoldesP_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new Form3_3());
        }

        private void btnGestock_Click(object sender, EventArgs e)
        {
            if(SubMenuGStock.Height==90)
            {
                SubMenuGStock.Visible = false;
            }
            else
            {
                SubMenuGStock.Height = 90;
            }
        }

        private void pictBoxMenu_Click(object sender, EventArgs e)
        {
        if (panelmenu.Width == 350)
            {
                panelmenu.Width = 78;
            }
            else
            {
                panelmenu.Width = 350;
            }
        if (panelLogo.Width == 350)
            {
                panelLogo.Width = 78;
            }
            else
            {
                panelLogo.Width = 350;
            }
        }
    }
}


