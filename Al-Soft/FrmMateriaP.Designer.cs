namespace Al_Soft
{
    partial class FrmMateriaP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMateriaP));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudCant = new System.Windows.Forms.NumericUpDown();
            this.txbNomMP = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbIDMatP = new System.Windows.Forms.TextBox();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.txbDescripción = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txbCostoXUni = new System.Windows.Forms.TextBox();
            this.lblCant = new System.Windows.Forms.Label();
            this.btnModifMP = new System.Windows.Forms.Button();
            this.btnAgregarMP = new System.Windows.Forms.Button();
            this.btnBorrarMP = new System.Windows.Forms.Button();
            this.TablaMatPrima = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaMatPrima)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nudCant);
            this.groupBox1.Controls.Add(this.txbNomMP);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txbIDMatP);
            this.groupBox1.Controls.Add(this.lblDescrip);
            this.groupBox1.Controls.Add(this.txbDescripción);
            this.groupBox1.Controls.Add(this.lblCosto);
            this.groupBox1.Controls.Add(this.txbCostoXUni);
            this.groupBox1.Controls.Add(this.lblCant);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Location = new System.Drawing.Point(41, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 218);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE MATERIA PRIMA:";
            // 
            // nudCant
            // 
            this.nudCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCant.Location = new System.Drawing.Point(697, 51);
            this.nudCant.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCant.Name = "nudCant";
            this.nudCant.ReadOnly = true;
            this.nudCant.Size = new System.Drawing.Size(95, 28);
            this.nudCant.TabIndex = 114;
            this.nudCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbNomMP
            // 
            this.txbNomMP.BackColor = System.Drawing.Color.White;
            this.txbNomMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomMP.Location = new System.Drawing.Point(180, 53);
            this.txbNomMP.Name = "txbNomMP";
            this.txbNomMP.Size = new System.Drawing.Size(344, 27);
            this.txbNomMP.TabIndex = 101;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblNombre.Location = new System.Drawing.Point(51, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 22);
            this.lblNombre.TabIndex = 100;
            this.lblNombre.Text = "Nombre:";
            // 
            // txbIDMatP
            // 
            this.txbIDMatP.BackColor = System.Drawing.Color.White;
            this.txbIDMatP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDMatP.Location = new System.Drawing.Point(697, 151);
            this.txbIDMatP.Name = "txbIDMatP";
            this.txbIDMatP.Size = new System.Drawing.Size(95, 27);
            this.txbIDMatP.TabIndex = 99;
            this.txbIDMatP.Visible = false;
            // 
            // lblDescrip
            // 
            this.lblDescrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.lblDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrip.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblDescrip.Location = new System.Drawing.Point(51, 103);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(121, 22);
            this.lblDescrip.TabIndex = 97;
            this.lblDescrip.Text = "Descripción:";
            // 
            // txbDescripción
            // 
            this.txbDescripción.BackColor = System.Drawing.Color.White;
            this.txbDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescripción.Location = new System.Drawing.Point(180, 105);
            this.txbDescripción.Multiline = true;
            this.txbDescripción.Name = "txbDescripción";
            this.txbDescripción.Size = new System.Drawing.Size(344, 85);
            this.txbDescripción.TabIndex = 98;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblCosto.Location = new System.Drawing.Point(597, 109);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(68, 22);
            this.lblCosto.TabIndex = 88;
            this.lblCosto.Text = "Costo:";
            // 
            // txbCostoXUni
            // 
            this.txbCostoXUni.BackColor = System.Drawing.Color.White;
            this.txbCostoXUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCostoXUni.Location = new System.Drawing.Point(697, 103);
            this.txbCostoXUni.Name = "txbCostoXUni";
            this.txbCostoXUni.Size = new System.Drawing.Size(95, 27);
            this.txbCostoXUni.TabIndex = 89;
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.lblCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblCant.Location = new System.Drawing.Point(587, 59);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(96, 22);
            this.lblCant.TabIndex = 87;
            this.lblCant.Text = "Cantidad:";
            // 
            // btnModifMP
            // 
            this.btnModifMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifMP.BackColor = System.Drawing.Color.HotPink;
            this.btnModifMP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModifMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifMP.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnModifMP.Location = new System.Drawing.Point(650, 278);
            this.btnModifMP.Name = "btnModifMP";
            this.btnModifMP.Size = new System.Drawing.Size(115, 40);
            this.btnModifMP.TabIndex = 112;
            this.btnModifMP.Text = "Modificar";
            this.btnModifMP.UseVisualStyleBackColor = false;
            this.btnModifMP.Click += new System.EventHandler(this.btnModifMP_Click);
            // 
            // btnAgregarMP
            // 
            this.btnAgregarMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarMP.BackColor = System.Drawing.Color.HotPink;
            this.btnAgregarMP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMP.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnAgregarMP.Location = new System.Drawing.Point(522, 278);
            this.btnAgregarMP.Name = "btnAgregarMP";
            this.btnAgregarMP.Size = new System.Drawing.Size(115, 40);
            this.btnAgregarMP.TabIndex = 111;
            this.btnAgregarMP.Text = "Agregar";
            this.btnAgregarMP.UseVisualStyleBackColor = false;
            this.btnAgregarMP.Click += new System.EventHandler(this.btnAgregarMP_Click);
            // 
            // btnBorrarMP
            // 
            this.btnBorrarMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarMP.BackColor = System.Drawing.Color.HotPink;
            this.btnBorrarMP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBorrarMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarMP.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnBorrarMP.Location = new System.Drawing.Point(777, 278);
            this.btnBorrarMP.Name = "btnBorrarMP";
            this.btnBorrarMP.Size = new System.Drawing.Size(115, 40);
            this.btnBorrarMP.TabIndex = 110;
            this.btnBorrarMP.Text = "Eliminar";
            this.btnBorrarMP.UseVisualStyleBackColor = false;
            this.btnBorrarMP.Click += new System.EventHandler(this.btnBorrarMP_Click);
            // 
            // TablaMatPrima
            // 
            this.TablaMatPrima.AllowUserToAddRows = false;
            this.TablaMatPrima.AllowUserToOrderColumns = true;
            this.TablaMatPrima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaMatPrima.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaMatPrima.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablaMatPrima.BackgroundColor = System.Drawing.Color.White;
            this.TablaMatPrima.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TablaMatPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaMatPrima.DefaultCellStyle = dataGridViewCellStyle1;
            this.TablaMatPrima.GridColor = System.Drawing.Color.White;
            this.TablaMatPrima.Location = new System.Drawing.Point(34, 335);
            this.TablaMatPrima.Name = "TablaMatPrima";
            this.TablaMatPrima.ReadOnly = true;
            this.TablaMatPrima.RowHeadersWidth = 45;
            this.TablaMatPrima.RowTemplate.Height = 24;
            this.TablaMatPrima.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaMatPrima.Size = new System.Drawing.Size(866, 346);
            this.TablaMatPrima.TabIndex = 112;
            this.TablaMatPrima.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaMatPrima_CellClick);
            // 
            // FrmMateriaP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(940, 718);
            this.Controls.Add(this.TablaMatPrima);
            this.Controls.Add(this.btnModifMP);
            this.Controls.Add(this.btnAgregarMP);
            this.Controls.Add(this.btnBorrarMP);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMateriaP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matera Prima";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaMatPrima)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDescrip;
        public System.Windows.Forms.TextBox txbDescripción;
        private System.Windows.Forms.Label lblCosto;
        public System.Windows.Forms.TextBox txbCostoXUni;
        private System.Windows.Forms.Label lblCant;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModifMP;
        private System.Windows.Forms.Button btnAgregarMP;
        private System.Windows.Forms.Button btnBorrarMP;
        public System.Windows.Forms.TextBox txbIDMatP;
        public System.Windows.Forms.TextBox txbNomMP;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.NumericUpDown nudCant;
        public System.Windows.Forms.DataGridView TablaMatPrima;
    }
}