namespace Al_Soft.Sistema_Usuarios
{
    partial class FrmReporteDiario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TablaIngr = new System.Windows.Forms.DataGridView();
            this.TablaEgr = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIngresos = new System.Windows.Forms.TextBox();
            this.txbEgresos = new System.Windows.Forms.TextBox();
            this.btnCierreCaja = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbIDCierreCaja = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSaldoTotal = new System.Windows.Forms.TextBox();
            this.labTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaIngr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEgr)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablaIngr
            // 
            this.TablaIngr.AllowUserToAddRows = false;
            this.TablaIngr.AllowUserToDeleteRows = false;
            this.TablaIngr.AllowUserToOrderColumns = true;
            this.TablaIngr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaIngr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaIngr.BackgroundColor = System.Drawing.Color.White;
            this.TablaIngr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TablaIngr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaIngr.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TablaIngr.GridColor = System.Drawing.Color.White;
            this.TablaIngr.Location = new System.Drawing.Point(29, 229);
            this.TablaIngr.Name = "TablaIngr";
            this.TablaIngr.RowHeadersWidth = 50;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(210)))));
            this.TablaIngr.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaIngr.RowTemplate.Height = 24;
            this.TablaIngr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaIngr.Size = new System.Drawing.Size(411, 310);
            this.TablaIngr.TabIndex = 109;
            // 
            // TablaEgr
            // 
            this.TablaEgr.AllowUserToAddRows = false;
            this.TablaEgr.AllowUserToDeleteRows = false;
            this.TablaEgr.AllowUserToOrderColumns = true;
            this.TablaEgr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaEgr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaEgr.BackgroundColor = System.Drawing.Color.White;
            this.TablaEgr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TablaEgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaEgr.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TablaEgr.GridColor = System.Drawing.Color.White;
            this.TablaEgr.Location = new System.Drawing.Point(501, 229);
            this.TablaEgr.Name = "TablaEgr";
            this.TablaEgr.RowHeadersWidth = 50;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(210)))));
            this.TablaEgr.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TablaEgr.RowTemplate.Height = 24;
            this.TablaEgr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaEgr.Size = new System.Drawing.Size(411, 310);
            this.TablaEgr.TabIndex = 132;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(124, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 133;
            this.label1.Text = "INGRESOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(648, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 134;
            this.label2.Text = "EGRESOS";
            // 
            // txbIngresos
            // 
            this.txbIngresos.Location = new System.Drawing.Point(160, 583);
            this.txbIngresos.Name = "txbIngresos";
            this.txbIngresos.ReadOnly = true;
            this.txbIngresos.Size = new System.Drawing.Size(126, 22);
            this.txbIngresos.TabIndex = 135;
            // 
            // txbEgresos
            // 
            this.txbEgresos.Location = new System.Drawing.Point(638, 583);
            this.txbEgresos.Name = "txbEgresos";
            this.txbEgresos.ReadOnly = true;
            this.txbEgresos.Size = new System.Drawing.Size(115, 22);
            this.txbEgresos.TabIndex = 136;
            // 
            // btnCierreCaja
            // 
            this.btnCierreCaja.BackColor = System.Drawing.Color.HotPink;
            this.btnCierreCaja.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCierreCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCierreCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierreCaja.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnCierreCaja.Location = new System.Drawing.Point(48, 38);
            this.btnCierreCaja.Name = "btnCierreCaja";
            this.btnCierreCaja.Size = new System.Drawing.Size(255, 40);
            this.btnCierreCaja.TabIndex = 137;
            this.btnCierreCaja.Text = "Cierre de Caja Diario";
            this.btnCierreCaja.UseVisualStyleBackColor = false;
            this.btnCierreCaja.Click += new System.EventHandler(this.btnCierreCaja_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(609, 551);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 29);
            this.label3.TabIndex = 138;
            this.label3.Text = "Total Egresos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.GhostWhite;
            this.label4.Location = new System.Drawing.Point(135, 551);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 29);
            this.label4.TabIndex = 139;
            this.label4.Text = "Total Ingresos";
            // 
            // txbIDCierreCaja
            // 
            this.txbIDCierreCaja.BackColor = System.Drawing.Color.White;
            this.txbIDCierreCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDCierreCaja.Location = new System.Drawing.Point(435, 157);
            this.txbIDCierreCaja.Name = "txbIDCierreCaja";
            this.txbIDCierreCaja.Size = new System.Drawing.Size(67, 27);
            this.txbIDCierreCaja.TabIndex = 140;
            this.txbIDCierreCaja.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCierreCaja);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(287, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 98);
            this.groupBox2.TabIndex = 141;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CIERRE DE CAJA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.GhostWhite;
            this.label5.Location = new System.Drawing.Point(408, 577);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 143;
            this.label5.Text = "Saldo total";
            // 
            // txbSaldoTotal
            // 
            this.txbSaldoTotal.Location = new System.Drawing.Point(419, 609);
            this.txbSaldoTotal.Name = "txbSaldoTotal";
            this.txbSaldoTotal.ReadOnly = true;
            this.txbSaldoTotal.Size = new System.Drawing.Size(115, 22);
            this.txbSaldoTotal.TabIndex = 142;
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.ForeColor = System.Drawing.Color.GhostWhite;
            this.labTitulo.Location = new System.Drawing.Point(24, 25);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(239, 29);
            this.labTitulo.TabIndex = 144;
            this.labTitulo.Text = "REGISTRO DIARIO";
            // 
            // FrmReporteDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(940, 718);
            this.Controls.Add(this.labTitulo);
            this.Controls.Add(this.txbIDCierreCaja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbSaldoTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbEgresos);
            this.Controls.Add(this.txbIngresos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TablaEgr);
            this.Controls.Add(this.TablaIngr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteDiario";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TablaIngr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEgr)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView TablaIngr;
        public System.Windows.Forms.DataGridView TablaEgr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbIngresos;
        private System.Windows.Forms.TextBox txbEgresos;
        private System.Windows.Forms.Button btnCierreCaja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txbIDCierreCaja;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSaldoTotal;
        private System.Windows.Forms.Label labTitulo;
    }
}