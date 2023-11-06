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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboxMolde = new System.Windows.Forms.ComboBox();
            this.lblElegirMol = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.TablaMedidas = new System.Windows.Forms.DataGridView();
            this.lblFechSolicit = new System.Windows.Forms.Label();
            this.dtpFechaSolicit = new System.Windows.Forms.DateTimePicker();
            this.lblCI = new System.Windows.Forms.Label();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.lblApellCli = new System.Windows.Forms.Label();
            this.txtApellCli = new System.Windows.Forms.TextBox();
            this.lblNomCli = new System.Windows.Forms.Label();
            this.txtNomCli = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaMedidas)).BeginInit();
            this.SuspendLayout();
            // 
            // comboxMolde
            // 
            this.comboxMolde.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxMolde.FormattingEnabled = true;
            this.comboxMolde.Location = new System.Drawing.Point(26, 287);
            this.comboxMolde.Name = "comboxMolde";
            this.comboxMolde.Size = new System.Drawing.Size(433, 31);
            this.comboxMolde.TabIndex = 93;
            // 
            // lblElegirMol
            // 
            this.lblElegirMol.AutoSize = true;
            this.lblElegirMol.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElegirMol.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblElegirMol.Location = new System.Drawing.Point(22, 255);
            this.lblElegirMol.Name = "lblElegirMol";
            this.lblElegirMol.Size = new System.Drawing.Size(128, 24);
            this.lblElegirMol.TabIndex = 92;
            this.lblElegirMol.Text = "Elegir Molde:";
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.White;
            this.txtTel.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(581, 100);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(282, 30);
            this.txtTel.TabIndex = 89;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblTel.Location = new System.Drawing.Point(459, 106);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(94, 24);
            this.lblTel.TabIndex = 88;
            this.lblTel.Text = "Teléfono:";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.lblDir.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDir.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblDir.Location = new System.Drawing.Point(459, 56);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(100, 24);
            this.lblDir.TabIndex = 87;
            this.lblDir.Text = "Dirección:";
            // 
            // txtDir
            // 
            this.txtDir.BackColor = System.Drawing.Color.White;
            this.txtDir.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDir.Location = new System.Drawing.Point(581, 54);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(282, 30);
            this.txtDir.TabIndex = 86;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.lblFechSolicit);
            this.groupBox1.Controls.Add(this.dtpFechaSolicit);
            this.groupBox1.Controls.Add(this.lblCI);
            this.groupBox1.Controls.Add(this.txtCI);
            this.groupBox1.Controls.Add(this.lblApellCli);
            this.groupBox1.Controls.Add(this.txtApellCli);
            this.groupBox1.Controls.Add(this.lblNomCli);
            this.groupBox1.Controls.Add(this.txtNomCli);
            this.groupBox1.Controls.Add(this.lblTel);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.lblDir);
            this.groupBox1.Controls.Add(this.txtDir);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 209);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE CLIENTES:";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.HotPink;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnModificar.Location = new System.Drawing.Point(619, 280);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(130, 40);
            this.btnModificar.TabIndex = 105;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.HotPink;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnGuardar.Location = new System.Drawing.Point(474, 280);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 40);
            this.btnGuardar.TabIndex = 104;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.HotPink;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnEliminar.Location = new System.Drawing.Point(768, 280);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 40);
            this.btnEliminar.TabIndex = 103;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.BackColor = System.Drawing.Color.HotPink;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnBuscar.Location = new System.Drawing.Point(26, 650);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(246, 40);
            this.btnBuscar.TabIndex = 107;
            this.btnBuscar.Text = "Buscar Cliente";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TablaMedidas
            // 
            this.TablaMedidas.AllowUserToAddRows = false;
            this.TablaMedidas.AllowUserToDeleteRows = false;
            this.TablaMedidas.AllowUserToOrderColumns = true;
            this.TablaMedidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaMedidas.BackgroundColor = System.Drawing.Color.White;
            this.TablaMedidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TablaMedidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaMedidas.GridColor = System.Drawing.Color.White;
            this.TablaMedidas.Location = new System.Drawing.Point(26, 326);
            this.TablaMedidas.Name = "TablaMedidas";
            this.TablaMedidas.ReadOnly = true;
            this.TablaMedidas.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(210)))));
            this.TablaMedidas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TablaMedidas.RowTemplate.Height = 24;
            this.TablaMedidas.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TablaMedidas.Size = new System.Drawing.Size(888, 308);
            this.TablaMedidas.TabIndex = 108;
            // 
            // lblFechSolicit
            // 
            this.lblFechSolicit.AutoSize = true;
            this.lblFechSolicit.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechSolicit.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblFechSolicit.Location = new System.Drawing.Point(459, 154);
            this.lblFechSolicit.Name = "lblFechSolicit";
            this.lblFechSolicit.Size = new System.Drawing.Size(154, 24);
            this.lblFechSolicit.TabIndex = 104;
            this.lblFechSolicit.Text = "Fecha Solicitud:";
            // 
            // dtpFechaSolicit
            // 
            this.dtpFechaSolicit.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaSolicit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSolicit.Location = new System.Drawing.Point(631, 148);
            this.dtpFechaSolicit.Name = "dtpFechaSolicit";
            this.dtpFechaSolicit.Size = new System.Drawing.Size(232, 30);
            this.dtpFechaSolicit.TabIndex = 103;
            // 
            // lblCI
            // 
            this.lblCI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCI.AutoSize = true;
            this.lblCI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.lblCI.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCI.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblCI.Location = new System.Drawing.Point(30, 154);
            this.lblCI.Name = "lblCI";
            this.lblCI.Size = new System.Drawing.Size(79, 24);
            this.lblCI.TabIndex = 102;
            this.lblCI.Text = "Cédula:";
            // 
            // txtCI
            // 
            this.txtCI.BackColor = System.Drawing.Color.White;
            this.txtCI.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCI.Location = new System.Drawing.Point(139, 148);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(282, 30);
            this.txtCI.TabIndex = 101;
            // 
            // lblApellCli
            // 
            this.lblApellCli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellCli.AutoSize = true;
            this.lblApellCli.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellCli.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblApellCli.Location = new System.Drawing.Point(30, 106);
            this.lblApellCli.Name = "lblApellCli";
            this.lblApellCli.Size = new System.Drawing.Size(88, 24);
            this.lblApellCli.TabIndex = 99;
            this.lblApellCli.Text = "Apellido:";
            // 
            // txtApellCli
            // 
            this.txtApellCli.BackColor = System.Drawing.Color.White;
            this.txtApellCli.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellCli.Location = new System.Drawing.Point(139, 100);
            this.txtApellCli.Name = "txtApellCli";
            this.txtApellCli.Size = new System.Drawing.Size(282, 30);
            this.txtApellCli.TabIndex = 100;
            // 
            // lblNomCli
            // 
            this.lblNomCli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomCli.AutoSize = true;
            this.lblNomCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.lblNomCli.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCli.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblNomCli.Location = new System.Drawing.Point(30, 56);
            this.lblNomCli.Name = "lblNomCli";
            this.lblNomCli.Size = new System.Drawing.Size(86, 24);
            this.lblNomCli.TabIndex = 97;
            this.lblNomCli.Text = "Nombre:";
            // 
            // txtNomCli
            // 
            this.txtNomCli.BackColor = System.Drawing.Color.White;
            this.txtNomCli.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomCli.Location = new System.Drawing.Point(139, 50);
            this.txtNomCli.Name = "txtNomCli";
            this.txtNomCli.Size = new System.Drawing.Size(282, 30);
            this.txtNomCli.TabIndex = 98;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(940, 710);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TablaMedidas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.comboxMolde);
            this.Controls.Add(this.lblElegirMol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaMedidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblElegirMol;
        public System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblDir;
        public System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView TablaMedidas;
        private System.Windows.Forms.Label lblFechSolicit;
        private System.Windows.Forms.DateTimePicker dtpFechaSolicit;
        private System.Windows.Forms.Label lblCI;
        public System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.Label lblApellCli;
        public System.Windows.Forms.TextBox txtApellCli;
        private System.Windows.Forms.Label lblNomCli;
        public System.Windows.Forms.TextBox txtNomCli;
        public System.Windows.Forms.ComboBox comboxMolde;
    }
}