using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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

        public void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cerrar del Programa?","Alerta ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);
            Application.Exit();
        }

        public void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        public void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormularios(object NuevoForm)
        {
            if (this.panelContenedor.Controls.Count >0) 
                this.panelContenedor.Controls.RemoveAt(0);  
            Form fh= NuevoForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void butCliente_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new Form3_1());
        }
    }
  }


