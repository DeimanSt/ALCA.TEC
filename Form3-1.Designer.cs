namespace Al_Soft
{
    partial class Form3_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Titulo4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNomCli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbApellidoCli = new System.Windows.Forms.TextBox();
            this.txbDireccionCli = new System.Windows.Forms.TextBox();
            this.txbCedulaCli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTelefooCli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePFecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconButLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.ID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cédula_Cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.Titulo4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 50);
            this.panel1.TabIndex = 5;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.btnMaximizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = global::Al_Soft.Properties.Resources.Maximizar;
            this.btnMaximizar.Location = new System.Drawing.Point(888, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(55, 48);
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.btnSalir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(943, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(55, 48);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Titulo4
            // 
            this.Titulo4.AutoSize = true;
            this.Titulo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo4.ForeColor = System.Drawing.Color.GhostWhite;
            this.Titulo4.Location = new System.Drawing.Point(47, 10);
            this.Titulo4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo4.Name = "Titulo4";
            this.Titulo4.Size = new System.Drawing.Size(165, 25);
            this.Titulo4.TabIndex = 0;
            this.Titulo4.Text = "Menú - Clientes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 52);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(91, 31);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.nuevaToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(81, 27);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.nuevaToolStripMenuItem.Text = "Nueva";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Direccion:";
            // 
            // txbNomCli
            // 
            this.txbNomCli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNomCli.BackColor = System.Drawing.Color.GhostWhite;
            this.txbNomCli.Location = new System.Drawing.Point(126, 44);
            this.txbNomCli.Name = "txbNomCli";
            this.txbNomCli.Size = new System.Drawing.Size(288, 24);
            this.txbNomCli.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 13;
            // 
            // txbApellidoCli
            // 
            this.txbApellidoCli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbApellidoCli.BackColor = System.Drawing.Color.GhostWhite;
            this.txbApellidoCli.Location = new System.Drawing.Point(124, 79);
            this.txbApellidoCli.Name = "txbApellidoCli";
            this.txbApellidoCli.Size = new System.Drawing.Size(288, 24);
            this.txbApellidoCli.TabIndex = 15;
            // 
            // txbDireccionCli
            // 
            this.txbDireccionCli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDireccionCli.BackColor = System.Drawing.Color.GhostWhite;
            this.txbDireccionCli.Location = new System.Drawing.Point(124, 121);
            this.txbDireccionCli.Name = "txbDireccionCli";
            this.txbDireccionCli.Size = new System.Drawing.Size(288, 24);
            this.txbDireccionCli.TabIndex = 16;
            // 
            // txbCedulaCli
            // 
            this.txbCedulaCli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCedulaCli.BackColor = System.Drawing.Color.GhostWhite;
            this.txbCedulaCli.Location = new System.Drawing.Point(554, 37);
            this.txbCedulaCli.Name = "txbCedulaCli";
            this.txbCedulaCli.Size = new System.Drawing.Size(185, 24);
            this.txbCedulaCli.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cédula:";
            // 
            // txbTelefooCli
            // 
            this.txbTelefooCli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTelefooCli.BackColor = System.Drawing.Color.GhostWhite;
            this.txbTelefooCli.Location = new System.Drawing.Point(554, 77);
            this.txbTelefooCli.Name = "txbTelefooCli";
            this.txbTelefooCli.Size = new System.Drawing.Size(185, 24);
            this.txbTelefooCli.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Teléfono:";
            // 
            // dateTimePFecha
            // 
            this.dateTimePFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePFecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(50)))), ((int)(((byte)(140)))));
            this.dateTimePFecha.Location = new System.Drawing.Point(554, 119);
            this.dateTimePFecha.Name = "dateTimePFecha";
            this.dateTimePFecha.Size = new System.Drawing.Size(187, 24);
            this.dateTimePFecha.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Fecha:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Cliente,
            this.Cédula_Cli,
            this.NombreCli,
            this.ApellidoCli,
            this.DirCliente,
            this.TelCliente});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(25, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(946, 372);
            this.dataGridView1.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.iconButLimpiar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txbApellidoCli);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePFecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbTelefooCli);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbNomCli);
            this.groupBox1.Controls.Add(this.txbCedulaCli);
            this.groupBox1.Controls.Add(this.txbDireccionCli);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 170);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL CLIENTE";
            // 
            // iconButLimpiar
            // 
            this.iconButLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButLimpiar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconButLimpiar.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.iconButLimpiar.IconColor = System.Drawing.Color.DodgerBlue;
            this.iconButLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButLimpiar.IconSize = 35;
            this.iconButLimpiar.Location = new System.Drawing.Point(825, 37);
            this.iconButLimpiar.Name = "iconButLimpiar";
            this.iconButLimpiar.Size = new System.Drawing.Size(55, 45);
            this.iconButLimpiar.TabIndex = 26;
            this.iconButLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnGuardar.Location = new System.Drawing.Point(778, 103);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 40);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Cargar Datos";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // ID_Cliente
            // 
            this.ID_Cliente.HeaderText = "ID";
            this.ID_Cliente.MinimumWidth = 6;
            this.ID_Cliente.Name = "ID_Cliente";
            this.ID_Cliente.Width = 125;
            // 
            // Cédula_Cli
            // 
            this.Cédula_Cli.HeaderText = "CI";
            this.Cédula_Cli.MinimumWidth = 6;
            this.Cédula_Cli.Name = "Cédula_Cli";
            this.Cédula_Cli.Width = 125;
            // 
            // NombreCli
            // 
            this.NombreCli.HeaderText = "Nombre";
            this.NombreCli.MinimumWidth = 6;
            this.NombreCli.Name = "NombreCli";
            this.NombreCli.Width = 125;
            // 
            // ApellidoCli
            // 
            this.ApellidoCli.HeaderText = "Apellido";
            this.ApellidoCli.MinimumWidth = 6;
            this.ApellidoCli.Name = "ApellidoCli";
            this.ApellidoCli.Width = 125;
            // 
            // DirCliente
            // 
            this.DirCliente.HeaderText = "Dirección";
            this.DirCliente.MinimumWidth = 6;
            this.DirCliente.Name = "DirCliente";
            this.DirCliente.Width = 125;
            // 
            // TelCliente
            // 
            this.TelCliente.HeaderText = "Teléfono/Celular";
            this.TelCliente.MinimumWidth = 6;
            this.TelCliente.Name = "TelCliente";
            this.TelCliente.Width = 125;
            // 
            // Form3_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form3_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label Titulo4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNomCli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbApellidoCli;
        private System.Windows.Forms.TextBox txbDireccionCli;
        private System.Windows.Forms.TextBox txbCedulaCli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbTelefooCli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private FontAwesome.Sharp.IconButton iconButLimpiar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cédula_Cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelCliente;
    }
}