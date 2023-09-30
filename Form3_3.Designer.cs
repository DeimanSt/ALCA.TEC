namespace Al_Soft
{
    partial class Form3_3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.txbStockMP = new System.Windows.Forms.TextBox();
            this.txbCostoMP = new System.Windows.Forms.TextBox();
            this.txbIDMaPrima = new System.Windows.Forms.TextBox();
            this.labDescripción = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtvMatPrima = new System.Windows.Forms.DataGridView();
            this.pnlBuscador = new System.Windows.Forms.Panel();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.labBuscar = new System.Windows.Forms.Label();
            this.txbBuscarProd = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMatPrima)).BeginInit();
            this.pnlBuscador.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbDescripcion);
            this.groupBox1.Controls.Add(this.txbStockMP);
            this.groupBox1.Controls.Add(this.txbCostoMP);
            this.groupBox1.Controls.Add(this.txbIDMaPrima);
            this.groupBox1.Controls.Add(this.labDescripción);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(28, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 209);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Stock de Materia Prima:";
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(388, 60);
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(480, 123);
            this.txbDescripcion.TabIndex = 9;
            // 
            // txbStockMP
            // 
            this.txbStockMP.Location = new System.Drawing.Point(138, 152);
            this.txbStockMP.Name = "txbStockMP";
            this.txbStockMP.Size = new System.Drawing.Size(199, 30);
            this.txbStockMP.TabIndex = 8;
            // 
            // txbCostoMP
            // 
            this.txbCostoMP.Location = new System.Drawing.Point(163, 104);
            this.txbCostoMP.Name = "txbCostoMP";
            this.txbCostoMP.Size = new System.Drawing.Size(174, 30);
            this.txbCostoMP.TabIndex = 7;
            // 
            // txbIDMaPrima
            // 
            this.txbIDMaPrima.Location = new System.Drawing.Point(138, 56);
            this.txbIDMaPrima.Name = "txbIDMaPrima";
            this.txbIDMaPrima.Size = new System.Drawing.Size(78, 30);
            this.txbIDMaPrima.TabIndex = 6;
            // 
            // labDescripción
            // 
            this.labDescripción.AutoSize = true;
            this.labDescripción.Location = new System.Drawing.Point(383, 32);
            this.labDescripción.Name = "labDescripción";
            this.labDescripción.Size = new System.Drawing.Size(257, 25);
            this.labDescripción.TabIndex = 3;
            this.labDescripción.Text = "Descripción del producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Costo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "$";
            // 
            // dtvMatPrima
            // 
            this.dtvMatPrima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvMatPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvMatPrima.Location = new System.Drawing.Point(28, 346);
            this.dtvMatPrima.Name = "dtvMatPrima";
            this.dtvMatPrima.RowHeadersWidth = 51;
            this.dtvMatPrima.RowTemplate.Height = 24;
            this.dtvMatPrima.Size = new System.Drawing.Size(890, 385);
            this.dtvMatPrima.TabIndex = 2;
            // 
            // pnlBuscador
            // 
            this.pnlBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBuscador.BackColor = System.Drawing.Color.HotPink;
            this.pnlBuscador.Controls.Add(this.btnBuscarProd);
            this.pnlBuscador.Controls.Add(this.labBuscar);
            this.pnlBuscador.Controls.Add(this.txbBuscarProd);
            this.pnlBuscador.Location = new System.Drawing.Point(28, 260);
            this.pnlBuscador.Name = "pnlBuscador";
            this.pnlBuscador.Size = new System.Drawing.Size(890, 64);
            this.pnlBuscador.TabIndex = 3;
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.BackColor = System.Drawing.Color.HotPink;
            this.btnBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProd.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProd.Location = new System.Drawing.Point(599, 12);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(107, 35);
            this.btnBuscarProd.TabIndex = 6;
            this.btnBuscarProd.Text = "Buscar";
            this.btnBuscarProd.UseVisualStyleBackColor = false;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // labBuscar
            // 
            this.labBuscar.AutoSize = true;
            this.labBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBuscar.ForeColor = System.Drawing.Color.White;
            this.labBuscar.Location = new System.Drawing.Point(16, 24);
            this.labBuscar.Name = "labBuscar";
            this.labBuscar.Size = new System.Drawing.Size(178, 25);
            this.labBuscar.TabIndex = 12;
            this.labBuscar.Text = "Buscar Producto:";
            // 
            // txbBuscarProd
            // 
            this.txbBuscarProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbBuscarProd.BackColor = System.Drawing.Color.White;
            this.txbBuscarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarProd.Location = new System.Drawing.Point(215, 20);
            this.txbBuscarProd.Name = "txbBuscarProd";
            this.txbBuscarProd.Size = new System.Drawing.Size(322, 27);
            this.txbBuscarProd.TabIndex = 0;
            // 
            // Form3_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(149)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(950, 755);
            this.Controls.Add(this.pnlBuscador);
            this.Controls.Add(this.dtvMatPrima);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3_3";
            this.Text = "Form3_3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMatPrima)).EndInit();
            this.pnlBuscador.ResumeLayout(false);
            this.pnlBuscador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbStockMP;
        private System.Windows.Forms.TextBox txbCostoMP;
        private System.Windows.Forms.TextBox txbIDMaPrima;
        private System.Windows.Forms.Label labDescripción;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtvMatPrima;
        private System.Windows.Forms.Panel pnlBuscador;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.Label labBuscar;
        private System.Windows.Forms.TextBox txbBuscarProd;
    }
}