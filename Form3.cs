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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3_1 fr= new Form3_1();  
            //fr.MdiParent = this;
            fr.Show();
        }

        private void btnInfoSoft_Click(object sender, EventArgs e)
        {

        }
    }
}
