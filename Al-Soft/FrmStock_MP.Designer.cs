namespace Al_Soft
{
    partial class FrmStock_MP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIDMateriaP = new System.Windows.Forms.TextBox();
            this.lblNomCli = new System.Windows.Forms.Label();
            this.txtDescripción = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtCostoXUnid = new System.Windows.Forms.TextBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.TablaMatPrima = new System.Windows.Forms.DataGridView();
            this.btnModifProd = new System.Windows.Forms.Button();
            this.btnAgregarProd = new System.Windows.Forms.Button();
            this.btnBorrarProd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaMatPrima)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtIDMateriaP);
            this.groupBox1.Controls.Add(this.lblNomCli);
            this.groupBox1.Controls.Add(this.txtDescripción);
            this.groupBox1.Controls.Add(this.lblTel);
            this.groupBox1.Controls.Add(this.txtCostoXUnid);
            this.groupBox1.Controls.Add(this.lblDir);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Location = new System.Drawing.Point(24, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 231);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE MATERIA PRIMA:";
            // 
            // txtIDMateriaP
            // 
            this.txtIDMateriaP.BackColor = System.Drawing.Color.White;
            this.txtIDMateriaP.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMateriaP.Location = new System.Drawing.Point(679, 170);
            this.txtIDMateriaP.Name = "txtIDMateriaP";
            this.txtIDMateriaP.Size = new System.Drawing.Size(58, 30);
            this.txtIDMateriaP.TabIndex = 101;
            this.txtIDMateriaP.Visible = false;
            // 
            // lblNomCli
            // 
            this.lblNomCli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomCli.AutoSize = true;
            this.lblNomCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.lblNomCli.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCli.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblNomCli.Location = new System.Drawing.Point(50, 45);
            this.lblNomCli.Name = "lblNomCli";
            this.lblNomCli.Size = new System.Drawing.Size(121, 24);
            this.lblNomCli.TabIndex = 97;
            this.lblNomCli.Text = "Descripción:";
            // 
            // txtDescripción
            // 
            this.txtDescripción.BackColor = System.Drawing.Color.White;
            this.txtDescripción.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripción.Location = new System.Drawing.Point(54, 78);
            this.txtDescripción.Multiline = true;
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Size = new System.Drawing.Size(416, 122);
            this.txtDescripción.TabIndex = 98;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblTel.Location = new System.Drawing.Point(512, 132);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(154, 24);
            this.lblTel.TabIndex = 88;
            this.lblTel.Text = "Costo x Unid:  $";
            // 
            // txtCostoXUnid
            // 
            this.txtCostoXUnid.BackColor = System.Drawing.Color.White;
            this.txtCostoXUnid.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoXUnid.Location = new System.Drawing.Point(679, 126);
            this.txtCostoXUnid.Name = "txtCostoXUnid";
            this.txtCostoXUnid.Size = new System.Drawing.Size(153, 30);
            this.txtCostoXUnid.TabIndex = 89;
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.lblDir.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDir.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblDir.Location = new System.Drawing.Point(570, 82);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(96, 24);
            this.lblDir.TabIndex = 87;
            this.lblDir.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(679, 76);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(153, 30);
            this.txtCantidad.TabIndex = 86;
            // 
            // TablaMatPrima
            // 
            this.TablaMatPrima.AllowUserToAddRows = false;
            this.TablaMatPrima.AllowUserToDeleteRows = false;
            this.TablaMatPrima.AllowUserToOrderColumns = true;
            this.TablaMatPrima.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaMatPrima.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.TablaMatPrima.BackgroundColor = System.Drawing.Color.White;
            this.TablaMatPrima.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TablaMatPrima.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaMatPrima.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaMatPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaMatPrima.DefaultCellStyle = dataGridViewCellStyle2;
            this.TablaMatPrima.GridColor = System.Drawing.Color.White;
            this.TablaMatPrima.Location = new System.Drawing.Point(24, 343);
            this.TablaMatPrima.Name = "TablaMatPrima";
            this.TablaMatPrima.ReadOnly = true;
            this.TablaMatPrima.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(210)))));
            this.TablaMatPrima.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaMatPrima.RowTemplate.Height = 24;
            this.TablaMatPrima.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TablaMatPrima.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaMatPrima.Size = new System.Drawing.Size(888, 335);
            this.TablaMatPrima.TabIndex = 109;
            // 
            // btnModifProd
            // 
            this.btnModifProd.BackColor = System.Drawing.Color.HotPink;
            this.btnModifProd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModifProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifProd.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifProd.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnModifProd.Location = new System.Drawing.Point(670, 291);
            this.btnModifProd.Name = "btnModifProd";
            this.btnModifProd.Size = new System.Drawing.Size(115, 40);
            this.btnModifProd.TabIndex = 112;
            this.btnModifProd.Text = "Modificar";
            this.btnModifProd.UseVisualStyleBackColor = false;
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.BackColor = System.Drawing.Color.HotPink;
            this.btnAgregarProd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProd.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProd.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnAgregarProd.Location = new System.Drawing.Point(541, 291);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(115, 40);
            this.btnAgregarProd.TabIndex = 111;
            this.btnAgregarProd.Text = "Agregar";
            this.btnAgregarProd.UseVisualStyleBackColor = false;
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // btnBorrarProd
            // 
            this.btnBorrarProd.BackColor = System.Drawing.Color.HotPink;
            this.btnBorrarProd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBorrarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarProd.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarProd.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnBorrarProd.Location = new System.Drawing.Point(797, 291);
            this.btnBorrarProd.Name = "btnBorrarProd";
            this.btnBorrarProd.Size = new System.Drawing.Size(115, 40);
            this.btnBorrarProd.TabIndex = 110;
            this.btnBorrarProd.Text = "Eliminar";
            this.btnBorrarProd.UseVisualStyleBackColor = false;
            // 
            // FrmStock_MP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(940, 700);
            this.Controls.Add(this.btnModifProd);
            this.Controls.Add(this.btnAgregarProd);
            this.Controls.Add(this.btnBorrarProd);
            this.Controls.Add(this.TablaMatPrima);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStock_MP";
            this.Text = "Stock de Matera Prima";
            this.Load += new System.EventHandler(this.FrmStock_MP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaMatPrima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtIDMateriaP;
        private System.Windows.Forms.Label lblNomCli;
        public System.Windows.Forms.TextBox txtDescripción;
        private System.Windows.Forms.Label lblTel;
        public System.Windows.Forms.TextBox txtCostoXUnid;
        private System.Windows.Forms.Label lblDir;
        public System.Windows.Forms.TextBox txtCantidad;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView TablaMatPrima;
        private System.Windows.Forms.Button btnModifProd;
        private System.Windows.Forms.Button btnAgregarProd;
        private System.Windows.Forms.Button btnBorrarProd;
    }
}