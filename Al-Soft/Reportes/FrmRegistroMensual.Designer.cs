namespace Al_Soft.Sistema_Usuarios
{
    partial class FrmRegistroMensual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroMensual));
            this.labTitulo = new System.Windows.Forms.Label();
            this.TablaMensual = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnU30D = new System.Windows.Forms.Button();
            this.btnHoy = new System.Windows.Forms.Button();
            this.btnU7D = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaMensual)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.ForeColor = System.Drawing.Color.GhostWhite;
            this.labTitulo.Location = new System.Drawing.Point(24, 20);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(275, 29);
            this.labTitulo.TabIndex = 1;
            this.labTitulo.Text = "REGISTRO MENSUAL";
            // 
            // TablaMensual
            // 
            this.TablaMensual.AllowUserToAddRows = false;
            this.TablaMensual.AllowUserToDeleteRows = false;
            this.TablaMensual.AllowUserToOrderColumns = true;
            this.TablaMensual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaMensual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaMensual.BackgroundColor = System.Drawing.Color.White;
            this.TablaMensual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TablaMensual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaMensual.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TablaMensual.GridColor = System.Drawing.Color.White;
            this.TablaMensual.Location = new System.Drawing.Point(29, 186);
            this.TablaMensual.Name = "TablaMensual";
            this.TablaMensual.RowHeadersWidth = 50;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(210)))));
            this.TablaMensual.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaMensual.RowTemplate.Height = 24;
            this.TablaMensual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaMensual.Size = new System.Drawing.Size(883, 436);
            this.TablaMensual.TabIndex = 109;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnU30D);
            this.groupBox1.Controls.Add(this.btnHoy);
            this.groupBox1.Controls.Add(this.btnU7D);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(41, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 109);
            this.groupBox1.TabIndex = 131;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR POR DIA:";
            // 
            // btnU30D
            // 
            this.btnU30D.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnU30D.AutoSize = true;
            this.btnU30D.BackColor = System.Drawing.Color.HotPink;
            this.btnU30D.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnU30D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU30D.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU30D.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnU30D.Location = new System.Drawing.Point(373, 49);
            this.btnU30D.Name = "btnU30D";
            this.btnU30D.Size = new System.Drawing.Size(162, 40);
            this.btnU30D.TabIndex = 134;
            this.btnU30D.Text = "Ultimos 30 Dias";
            this.btnU30D.UseVisualStyleBackColor = false;
            this.btnU30D.Click += new System.EventHandler(this.btnU30D_Click);
            // 
            // btnHoy
            // 
            this.btnHoy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHoy.AutoSize = true;
            this.btnHoy.BackColor = System.Drawing.Color.HotPink;
            this.btnHoy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoy.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnHoy.Location = new System.Drawing.Point(23, 48);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(141, 40);
            this.btnHoy.TabIndex = 133;
            this.btnHoy.Text = "Hoy";
            this.btnHoy.UseVisualStyleBackColor = false;
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click_1);
            // 
            // btnU7D
            // 
            this.btnU7D.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnU7D.AutoSize = true;
            this.btnU7D.BackColor = System.Drawing.Color.HotPink;
            this.btnU7D.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnU7D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU7D.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU7D.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnU7D.Location = new System.Drawing.Point(198, 49);
            this.btnU7D.Name = "btnU7D";
            this.btnU7D.Size = new System.Drawing.Size(151, 40);
            this.btnU7D.TabIndex = 132;
            this.btnU7D.Text = "Ultimos 7 Dias";
            this.btnU7D.UseVisualStyleBackColor = false;
            this.btnU7D.Click += new System.EventHandler(this.btnU7D_Click);
            // 
            // FrmRegistroMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(940, 718);
            this.Controls.Add(this.TablaMensual);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistroMensual";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TablaMensual)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitulo;
        public System.Windows.Forms.DataGridView TablaMensual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnU7D;
        private System.Windows.Forms.Button btnHoy;
        private System.Windows.Forms.Button btnU30D;
    }
}