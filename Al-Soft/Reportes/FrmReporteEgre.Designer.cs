namespace Al_Soft
{
    partial class FrmReporteEgre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteEgre));
            this.btnCdC = new System.Windows.Forms.Button();
            this.btnBorrarEgr = new System.Windows.Forms.Button();
            this.TablaEgr = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNomCli = new System.Windows.Forms.Label();
            this.txbDescripciónE = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txbCostoEgr = new System.Windows.Forms.TextBox();
            this.txbIDEgreso = new System.Windows.Forms.TextBox();
            this.btnModifEgr = new System.Windows.Forms.Button();
            this.btnAgregarEgr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEgr)).BeginInit();
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
            // btnBorrarEgr
            // 
            this.btnBorrarEgr.BackColor = System.Drawing.Color.HotPink;
            this.btnBorrarEgr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBorrarEgr.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBorrarEgr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarEgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarEgr.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnBorrarEgr.Location = new System.Drawing.Point(484, 170);
            this.btnBorrarEgr.Name = "btnBorrarEgr";
            this.btnBorrarEgr.Size = new System.Drawing.Size(255, 40);
            this.btnBorrarEgr.TabIndex = 127;
            this.btnBorrarEgr.Text = "Eliminar";
            this.btnBorrarEgr.UseVisualStyleBackColor = false;
            this.btnBorrarEgr.Click += new System.EventHandler(this.btnBorrarEgr_Click);
            // 
            // TablaEgr
            // 
            this.TablaEgr.AllowUserToAddRows = false;
            this.TablaEgr.AllowUserToDeleteRows = false;
            this.TablaEgr.AllowUserToOrderColumns = true;
            this.TablaEgr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaEgr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaEgr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.TablaEgr.BackgroundColor = System.Drawing.Color.White;
            this.TablaEgr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaEgr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaEgr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaEgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaEgr.GridColor = System.Drawing.Color.White;
            this.TablaEgr.Location = new System.Drawing.Point(12, 239);
            this.TablaEgr.Name = "TablaEgr";
            this.TablaEgr.ReadOnly = true;
            this.TablaEgr.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(210)))));
            this.TablaEgr.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TablaEgr.RowTemplate.Height = 24;
            this.TablaEgr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaEgr.Size = new System.Drawing.Size(916, 353);
            this.TablaEgr.TabIndex = 126;
            this.TablaEgr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaEgr_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.lblNomCli);
            this.groupBox1.Controls.Add(this.txbDescripciónE);
            this.groupBox1.Controls.Add(this.lblTel);
            this.groupBox1.Controls.Add(this.txbCostoEgr);
            this.groupBox1.Controls.Add(this.txbIDEgreso);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 142);
            this.groupBox1.TabIndex = 125;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE EGRESOS DIARIOS";
            // 
            // lblNomCli
            // 
            this.lblNomCli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomCli.AutoSize = true;
            this.lblNomCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.lblNomCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCli.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblNomCli.Location = new System.Drawing.Point(6, 30);
            this.lblNomCli.Name = "lblNomCli";
            this.lblNomCli.Size = new System.Drawing.Size(121, 44);
            this.lblNomCli.TabIndex = 146;
            this.lblNomCli.Text = "Descripción \r\nEgreso:";
            // 
            // txbDescripciónE
            // 
            this.txbDescripciónE.BackColor = System.Drawing.Color.White;
            this.txbDescripciónE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescripciónE.Location = new System.Drawing.Point(133, 48);
            this.txbDescripciónE.Multiline = true;
            this.txbDescripciónE.Name = "txbDescripciónE";
            this.txbDescripciónE.Size = new System.Drawing.Size(153, 26);
            this.txbDescripciónE.TabIndex = 147;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblTel.Location = new System.Drawing.Point(6, 90);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(68, 22);
            this.lblTel.TabIndex = 144;
            this.lblTel.Text = "Costo:";
            // 
            // txbCostoEgr
            // 
            this.txbCostoEgr.BackColor = System.Drawing.Color.White;
            this.txbCostoEgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCostoEgr.Location = new System.Drawing.Point(133, 85);
            this.txbCostoEgr.Name = "txbCostoEgr";
            this.txbCostoEgr.Size = new System.Drawing.Size(153, 27);
            this.txbCostoEgr.TabIndex = 145;
            // 
            // txbIDEgreso
            // 
            this.txbIDEgreso.BackColor = System.Drawing.Color.White;
            this.txbIDEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDEgreso.Location = new System.Drawing.Point(307, 85);
            this.txbIDEgreso.Name = "txbIDEgreso";
            this.txbIDEgreso.Size = new System.Drawing.Size(67, 27);
            this.txbIDEgreso.TabIndex = 143;
            this.txbIDEgreso.Visible = false;
            // 
            // btnModifEgr
            // 
            this.btnModifEgr.BackColor = System.Drawing.Color.HotPink;
            this.btnModifEgr.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModifEgr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifEgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifEgr.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnModifEgr.Location = new System.Drawing.Point(484, 116);
            this.btnModifEgr.Name = "btnModifEgr";
            this.btnModifEgr.Size = new System.Drawing.Size(255, 40);
            this.btnModifEgr.TabIndex = 129;
            this.btnModifEgr.Text = "Modificar";
            this.btnModifEgr.UseVisualStyleBackColor = false;
            this.btnModifEgr.Click += new System.EventHandler(this.btnModifEgr_Click);
            // 
            // btnAgregarEgr
            // 
            this.btnAgregarEgr.BackColor = System.Drawing.Color.HotPink;
            this.btnAgregarEgr.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarEgr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEgr.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnAgregarEgr.Location = new System.Drawing.Point(484, 60);
            this.btnAgregarEgr.Name = "btnAgregarEgr";
            this.btnAgregarEgr.Size = new System.Drawing.Size(255, 40);
            this.btnAgregarEgr.TabIndex = 132;
            this.btnAgregarEgr.Text = "Agregar";
            this.btnAgregarEgr.UseVisualStyleBackColor = false;
            this.btnAgregarEgr.Click += new System.EventHandler(this.btnAgregarEgr_Click);
            // 
            // FrmReporteEgre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(940, 718);
            this.Controls.Add(this.btnAgregarEgr);
            this.Controls.Add(this.btnCdC);
            this.Controls.Add(this.btnModifEgr);
            this.Controls.Add(this.btnBorrarEgr);
            this.Controls.Add(this.TablaEgr);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteEgre";
            this.Text = "FrmReporteIngr";
            this.Load += new System.EventHandler(this.FrmReporteEgre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaEgr)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCdC;
        private System.Windows.Forms.Button btnBorrarEgr;
        private System.Windows.Forms.DataGridView TablaEgr;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModifEgr;
        private System.Windows.Forms.Label lblNomCli;
        public System.Windows.Forms.TextBox txbDescripciónE;
        private System.Windows.Forms.Label lblTel;
        public System.Windows.Forms.TextBox txbCostoEgr;
        public System.Windows.Forms.TextBox txbIDEgreso;
        private System.Windows.Forms.Button btnAgregarEgr;
    }
}