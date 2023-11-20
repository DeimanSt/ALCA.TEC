namespace Al_Soft
{
    partial class FrmReporteIngr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteIngr));
            this.btnCdC = new System.Windows.Forms.Button();
            this.btnAgregarProd = new System.Windows.Forms.Button();
            this.btnBorrarProd = new System.Windows.Forms.Button();
            this.TablaIngreso = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.txbIDIngreso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbHoras = new System.Windows.Forms.TextBox();
            this.lblNomCli = new System.Windows.Forms.Label();
            this.txbDescripción = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txbCostoXUnid = new System.Windows.Forms.TextBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.btnModifProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaIngreso)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCdC
            // 
            this.btnCdC.BackColor = System.Drawing.Color.HotPink;
            this.btnCdC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCdC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCdC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCdC.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnCdC.Location = new System.Drawing.Point(960, 981);
            this.btnCdC.Name = "btnCdC";
            this.btnCdC.Size = new System.Drawing.Size(191, 40);
            this.btnCdC.TabIndex = 131;
            this.btnCdC.Text = " ";
            this.btnCdC.UseVisualStyleBackColor = false;
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.BackColor = System.Drawing.Color.HotPink;
            this.btnAgregarProd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProd.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnAgregarProd.Location = new System.Drawing.Point(555, 87);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(255, 40);
            this.btnAgregarProd.TabIndex = 128;
            this.btnAgregarProd.Text = "Agregar";
            this.btnAgregarProd.UseVisualStyleBackColor = false;
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // btnBorrarProd
            // 
            this.btnBorrarProd.BackColor = System.Drawing.Color.HotPink;
            this.btnBorrarProd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBorrarProd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBorrarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarProd.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnBorrarProd.Location = new System.Drawing.Point(555, 230);
            this.btnBorrarProd.Name = "btnBorrarProd";
            this.btnBorrarProd.Size = new System.Drawing.Size(255, 40);
            this.btnBorrarProd.TabIndex = 127;
            this.btnBorrarProd.Text = "Eliminar";
            this.btnBorrarProd.UseVisualStyleBackColor = false;
            this.btnBorrarProd.Click += new System.EventHandler(this.btnBorrarProd_Click);
            // 
            // TablaIngreso
            // 
            this.TablaIngreso.AllowUserToAddRows = false;
            this.TablaIngreso.AllowUserToDeleteRows = false;
            this.TablaIngreso.AllowUserToOrderColumns = true;
            this.TablaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaIngreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaIngreso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.TablaIngreso.BackgroundColor = System.Drawing.Color.White;
            this.TablaIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaIngreso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaIngreso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaIngreso.GridColor = System.Drawing.Color.White;
            this.TablaIngreso.Location = new System.Drawing.Point(12, 295);
            this.TablaIngreso.Name = "TablaIngreso";
            this.TablaIngreso.ReadOnly = true;
            this.TablaIngreso.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(210)))));
            this.TablaIngreso.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TablaIngreso.RowTemplate.Height = 24;
            this.TablaIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaIngreso.Size = new System.Drawing.Size(880, 319);
            this.TablaIngreso.TabIndex = 126;
            this.TablaIngreso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaIngreso_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.dtpFechaRetiro);
            this.groupBox1.Controls.Add(this.txbIDIngreso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbHoras);
            this.groupBox1.Controls.Add(this.lblNomCli);
            this.groupBox1.Controls.Add(this.txbDescripción);
            this.groupBox1.Controls.Add(this.lblTel);
            this.groupBox1.Controls.Add(this.txbCostoXUnid);
            this.groupBox1.Controls.Add(this.lblDir);
            this.groupBox1.Controls.Add(this.txbCantidad);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 273);
            this.groupBox1.TabIndex = 125;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE INGRESOS DIARIOS";
            // 
            // dtpFechaRetiro
            // 
            this.dtpFechaRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRetiro.Location = new System.Drawing.Point(174, 219);
            this.dtpFechaRetiro.MinDate = new System.DateTime(2023, 11, 17, 0, 0, 0, 0);
            this.dtpFechaRetiro.Name = "dtpFechaRetiro";
            this.dtpFechaRetiro.Size = new System.Drawing.Size(325, 28);
            this.dtpFechaRetiro.TabIndex = 146;
            this.dtpFechaRetiro.Value = new System.DateTime(2023, 11, 17, 0, 0, 0, 0);
            // 
            // txbIDIngreso
            // 
            this.txbIDIngreso.BackColor = System.Drawing.Color.White;
            this.txbIDIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDIngreso.Location = new System.Drawing.Point(367, 29);
            this.txbIDIngreso.Name = "txbIDIngreso";
            this.txbIDIngreso.Size = new System.Drawing.Size(67, 27);
            this.txbIDIngreso.TabIndex = 133;
            this.txbIDIngreso.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(25, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 145;
            this.label1.Text = "Fecha Entrega:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.GhostWhite;
            this.label7.Location = new System.Drawing.Point(92, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 22);
            this.label7.TabIndex = 143;
            this.label7.Text = "Horas:";
            // 
            // txbHoras
            // 
            this.txbHoras.BackColor = System.Drawing.Color.White;
            this.txbHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHoras.Location = new System.Drawing.Point(174, 176);
            this.txbHoras.Name = "txbHoras";
            this.txbHoras.Size = new System.Drawing.Size(153, 27);
            this.txbHoras.TabIndex = 144;
            // 
            // lblNomCli
            // 
            this.lblNomCli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomCli.AutoSize = true;
            this.lblNomCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.lblNomCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCli.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblNomCli.Location = new System.Drawing.Point(47, 34);
            this.lblNomCli.Name = "lblNomCli";
            this.lblNomCli.Size = new System.Drawing.Size(121, 22);
            this.lblNomCli.TabIndex = 141;
            this.lblNomCli.Text = "Descripción:";
            // 
            // txbDescripción
            // 
            this.txbDescripción.BackColor = System.Drawing.Color.White;
            this.txbDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescripción.Location = new System.Drawing.Point(174, 30);
            this.txbDescripción.Multiline = true;
            this.txbDescripción.Name = "txbDescripción";
            this.txbDescripción.Size = new System.Drawing.Size(153, 26);
            this.txbDescripción.TabIndex = 142;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblTel.Location = new System.Drawing.Point(7, 134);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(154, 22);
            this.lblTel.TabIndex = 139;
            this.lblTel.Text = "Costo x Unid:  $";
            // 
            // txbCostoXUnid
            // 
            this.txbCostoXUnid.BackColor = System.Drawing.Color.White;
            this.txbCostoXUnid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCostoXUnid.Location = new System.Drawing.Point(174, 128);
            this.txbCostoXUnid.Name = "txbCostoXUnid";
            this.txbCostoXUnid.Size = new System.Drawing.Size(153, 27);
            this.txbCostoXUnid.TabIndex = 140;
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.lblDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDir.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblDir.Location = new System.Drawing.Point(65, 84);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(96, 22);
            this.lblDir.TabIndex = 138;
            this.lblDir.Text = "Cantidad:";
            // 
            // txbCantidad
            // 
            this.txbCantidad.BackColor = System.Drawing.Color.White;
            this.txbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCantidad.Location = new System.Drawing.Point(174, 78);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(153, 27);
            this.txbCantidad.TabIndex = 137;
            // 
            // btnModifProd
            // 
            this.btnModifProd.BackColor = System.Drawing.Color.HotPink;
            this.btnModifProd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModifProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifProd.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnModifProd.Location = new System.Drawing.Point(555, 158);
            this.btnModifProd.Name = "btnModifProd";
            this.btnModifProd.Size = new System.Drawing.Size(255, 40);
            this.btnModifProd.TabIndex = 129;
            this.btnModifProd.Text = "Modificar";
            this.btnModifProd.UseVisualStyleBackColor = false;
            this.btnModifProd.Click += new System.EventHandler(this.btnModifProd_Click);
            // 
            // FrmReporteIngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(100, 400);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(940, 718);
            this.Controls.Add(this.btnCdC);
            this.Controls.Add(this.btnModifProd);
            this.Controls.Add(this.btnAgregarProd);
            this.Controls.Add(this.btnBorrarProd);
            this.Controls.Add(this.TablaIngreso);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteIngr";
            this.Text = "FrmReporteIngr";
            this.Load += new System.EventHandler(this.FrmReporteIngr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaIngreso)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCdC;
        private System.Windows.Forms.Button btnAgregarProd;
        private System.Windows.Forms.Button btnBorrarProd;
        private System.Windows.Forms.DataGridView TablaIngreso;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModifProd;
        public System.Windows.Forms.TextBox txbIDIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaRetiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txbHoras;
        private System.Windows.Forms.Label lblNomCli;
        public System.Windows.Forms.TextBox txbDescripción;
        private System.Windows.Forms.Label lblTel;
        public System.Windows.Forms.TextBox txbCostoXUnid;
        private System.Windows.Forms.Label lblDir;
        public System.Windows.Forms.TextBox txbCantidad;
    }
}