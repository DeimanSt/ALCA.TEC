using Al_Soft.Sistema_Usuarios;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Al_Soft
{
    public partial class FrmMenú : Form
    {
        public FrmMenú()
        {
            InitializeComponent();
            pnlSubMenu.Visible = false;

            this.Load += FrmMenú_Load;

            pnlSubMenu.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasedCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int Param, int lParam);

        private void pnlCntrlMenú_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasedCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        int LY, LX;

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;

            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1250, 740);
            this.Location = new Point(LX, LY);
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir del Programa?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
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
            NuevoForm.BringToFront();
            NuevoForm.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmClientes());
        }

        private void btnCuentaUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmRegistro());
        }

        private void OcultarSubMenu()
        {
            if (pnlSubMenu.Visible == true)
            {
                pnlSubMenu.Visible = false;
            }
        }

        private void MostrarSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                OcultarSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlSubMenu);
        }

        private void btnRegistroIngreso_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmReporteIngr());
        }

        private void btnCtrlGráfico_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmControlGráfico());
        }

        private void btnRegistroEgreso_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmReporteEgre());
        }

        private void btnReporteDia_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmReporteDiario());
        }

        private void btnReporteSemanal_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmRegistroMensual());
        }

        private void FrmMenú_Load(object sender, EventArgs e)
        {
            string carpetaPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "RegistroMensual");

            if (!Directory.Exists(carpetaPath))
            {
                Directory.CreateDirectory(carpetaPath);
            }
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStockMP_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmMateriaP());
        }
    }
}
