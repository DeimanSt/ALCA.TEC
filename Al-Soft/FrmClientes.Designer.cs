namespace Al_Soft
{
    partial class FrmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.cmbxBuscar = new System.Windows.Forms.ComboBox();
            this.lblElegirMol = new System.Windows.Forms.Label();
            this.txbTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.txbDir = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbIDCliente = new System.Windows.Forms.TextBox();
            this.lblCI = new System.Windows.Forms.Label();
            this.txbCedula = new System.Windows.Forms.TextBox();
            this.lblApellCli = new System.Windows.Forms.Label();
            this.txbApeCli = new System.Windows.Forms.TextBox();
            this.lblNomCli = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txbNomCli = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.TablaClientes = new System.Windows.Forms.DataGridView();
            this.txbBuscarCli = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaClientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbxBuscar
            // 
            this.cmbxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxBuscar.FormattingEnabled = true;
            this.cmbxBuscar.Location = new System.Drawing.Point(40, 50);
            this.cmbxBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbxBuscar.Name = "cmbxBuscar";
            this.cmbxBuscar.Size = new System.Drawing.Size(170, 28);
            this.cmbxBuscar.TabIndex = 93;
            // 
            // lblElegirMol
            // 
            this.lblElegirMol.AutoSize = true;
            this.lblElegirMol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElegirMol.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblElegirMol.Location = new System.Drawing.Point(38, 26);
            this.lblElegirMol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElegirMol.Name = "lblElegirMol";
            this.lblElegirMol.Size = new System.Drawing.Size(106, 22);
            this.lblElegirMol.TabIndex = 92;
            this.lblElegirMol.Text = "Filtrar Por:";
            // 
            // txbTel
            // 
            this.txbTel.BackColor = System.Drawing.Color.White;
            this.txbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTel.Location = new System.Drawing.Point(451, 81);
            this.txbTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbTel.Name = "txbTel";
            this.txbTel.Size = new System.Drawing.Size(180, 27);
            this.txbTel.TabIndex = 89;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblTel.Location = new System.Drawing.Point(350, 86);
            this.lblTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(95, 22);
            this.lblTel.TabIndex = 88;
            this.lblTel.Text = "Teléfono:";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.lblDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDir.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblDir.Location = new System.Drawing.Point(24, 130);
            this.lblDir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(100, 22);
            this.lblDir.TabIndex = 87;
            this.lblDir.Text = "Dirección:";
            // 
            // txbDir
            // 
            this.txbDir.BackColor = System.Drawing.Color.White;
            this.txbDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDir.Location = new System.Drawing.Point(127, 125);
            this.txbDir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbDir.Name = "txbDir";
            this.txbDir.Size = new System.Drawing.Size(212, 27);
            this.txbDir.TabIndex = 86;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txbIDCliente);
            this.groupBox1.Controls.Add(this.lblCI);
            this.groupBox1.Controls.Add(this.txbCedula);
            this.groupBox1.Controls.Add(this.lblApellCli);
            this.groupBox1.Controls.Add(this.txbApeCli);
            this.groupBox1.Controls.Add(this.lblNomCli);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txbNomCli);
            this.groupBox1.Controls.Add(this.lblTel);
            this.groupBox1.Controls.Add(this.txbTel);
            this.groupBox1.Controls.Add(this.lblDir);
            this.groupBox1.Controls.Add(this.txbDir);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(661, 177);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE CLIENTES:";
            // 
            // txbIDCliente
            // 
            this.txbIDCliente.BackColor = System.Drawing.Color.White;
            this.txbIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDCliente.Location = new System.Drawing.Point(0, 7);
            this.txbIDCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbIDCliente.Multiline = true;
            this.txbIDCliente.Name = "txbIDCliente";
            this.txbIDCliente.Size = new System.Drawing.Size(8, 9);
            this.txbIDCliente.TabIndex = 105;
            this.txbIDCliente.Visible = false;
            // 
            // lblCI
            // 
            this.lblCI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCI.AutoSize = true;
            this.lblCI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.lblCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCI.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblCI.Location = new System.Drawing.Point(369, 46);
            this.lblCI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCI.Name = "lblCI";
            this.lblCI.Size = new System.Drawing.Size(79, 22);
            this.lblCI.TabIndex = 102;
            this.lblCI.Text = "Cédula:";
            // 
            // txbCedula
            // 
            this.txbCedula.BackColor = System.Drawing.Color.White;
            this.txbCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCedula.Location = new System.Drawing.Point(451, 41);
            this.txbCedula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbCedula.Name = "txbCedula";
            this.txbCedula.Size = new System.Drawing.Size(180, 27);
            this.txbCedula.TabIndex = 101;
            // 
            // lblApellCli
            // 
            this.lblApellCli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellCli.AutoSize = true;
            this.lblApellCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellCli.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblApellCli.Location = new System.Drawing.Point(37, 86);
            this.lblApellCli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellCli.Name = "lblApellCli";
            this.lblApellCli.Size = new System.Drawing.Size(88, 22);
            this.lblApellCli.TabIndex = 99;
            this.lblApellCli.Text = "Apellido:";
            // 
            // txbApeCli
            // 
            this.txbApeCli.BackColor = System.Drawing.Color.White;
            this.txbApeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApeCli.Location = new System.Drawing.Point(127, 81);
            this.txbApeCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbApeCli.Name = "txbApeCli";
            this.txbApeCli.Size = new System.Drawing.Size(212, 27);
            this.txbApeCli.TabIndex = 100;
            // 
            // lblNomCli
            // 
            this.lblNomCli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomCli.AutoSize = true;
            this.lblNomCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.lblNomCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCli.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblNomCli.Location = new System.Drawing.Point(41, 46);
            this.lblNomCli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomCli.Name = "lblNomCli";
            this.lblNomCli.Size = new System.Drawing.Size(85, 22);
            this.lblNomCli.TabIndex = 97;
            this.lblNomCli.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.HotPink;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnGuardar.Location = new System.Drawing.Point(482, 115);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 32);
            this.btnGuardar.TabIndex = 104;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txbNomCli
            // 
            this.txbNomCli.BackColor = System.Drawing.Color.White;
            this.txbNomCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomCli.Location = new System.Drawing.Point(127, 41);
            this.txbNomCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbNomCli.Name = "txbNomCli";
            this.txbNomCli.Size = new System.Drawing.Size(212, 27);
            this.txbNomCli.TabIndex = 98;
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = true;
            this.btnModificar.BackColor = System.Drawing.Color.HotPink;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnModificar.Location = new System.Drawing.Point(574, 214);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(103, 34);
            this.btnModificar.TabIndex = 105;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.BackColor = System.Drawing.Color.HotPink;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnEliminar.Location = new System.Drawing.Point(574, 254);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 34);
            this.btnEliminar.TabIndex = 103;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.BackColor = System.Drawing.Color.HotPink;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnBuscar.Location = new System.Drawing.Point(423, 43);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 34);
            this.btnBuscar.TabIndex = 107;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TablaClientes
            // 
            this.TablaClientes.AllowUserToAddRows = false;
            this.TablaClientes.AllowUserToDeleteRows = false;
            this.TablaClientes.AllowUserToOrderColumns = true;
            this.TablaClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaClientes.BackgroundColor = System.Drawing.Color.White;
            this.TablaClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TablaClientes.GridColor = System.Drawing.Color.White;
            this.TablaClientes.Location = new System.Drawing.Point(20, 304);
            this.TablaClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TablaClientes.Name = "TablaClientes";
            this.TablaClientes.RowHeadersWidth = 50;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(210)))));
            this.TablaClientes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaClientes.RowTemplate.Height = 24;
            this.TablaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaClientes.Size = new System.Drawing.Size(662, 229);
            this.TablaClientes.TabIndex = 108;
            this.TablaClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaClientes_CellClick);
            // 
            // txbBuscarCli
            // 
            this.txbBuscarCli.BackColor = System.Drawing.Color.White;
            this.txbBuscarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarCli.Location = new System.Drawing.Point(221, 50);
            this.txbBuscarCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbBuscarCli.Name = "txbBuscarCli";
            this.txbBuscarCli.Size = new System.Drawing.Size(188, 27);
            this.txbBuscarCli.TabIndex = 105;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbxBuscar);
            this.groupBox2.Controls.Add(this.txbBuscarCli);
            this.groupBox2.Controls.Add(this.lblElegirMol);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(20, 205);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(532, 89);
            this.groupBox2.TabIndex = 109;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSCAR CLIENTE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(218, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 108;
            this.label1.Text = "Buscar Nombre:";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(705, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TablaClientes);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaClientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblElegirMol;
        public System.Windows.Forms.TextBox txbTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblDir;
        public System.Windows.Forms.TextBox txbDir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCI;
        public System.Windows.Forms.TextBox txbCedula;
        private System.Windows.Forms.Label lblApellCli;
        public System.Windows.Forms.TextBox txbApeCli;
        private System.Windows.Forms.Label lblNomCli;
        public System.Windows.Forms.TextBox txbNomCli;
        public System.Windows.Forms.ComboBox cmbxBuscar;
        public System.Windows.Forms.TextBox txbBuscarCli;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txbIDCliente;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView TablaClientes;
    }
}