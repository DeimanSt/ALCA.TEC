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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txbCantStock = new System.Windows.Forms.TextBox();
            this.labCosto = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.labStockMP = new System.Windows.Forms.Label();
            this.txbDescrip = new System.Windows.Forms.TextBox();
            this.labpesos = new System.Windows.Forms.Label();
            this.labDescrip = new System.Windows.Forms.Label();
            this.txbCosto = new System.Windows.Forms.TextBox();
            this.dgvMatPrima = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatPrima)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.txbCantStock);
            this.groupBox1.Controls.Add(this.labCosto);
            this.groupBox1.Controls.Add(this.btnAñadir);
            this.groupBox1.Controls.Add(this.labStockMP);
            this.groupBox1.Controls.Add(this.txbDescrip);
            this.groupBox1.Controls.Add(this.labpesos);
            this.groupBox1.Controls.Add(this.labDescrip);
            this.groupBox1.Controls.Add(this.txbCosto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(84, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestión de Materia Prima:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.HotPink;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(580, 167);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 35);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.HotPink;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(580, 104);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(124, 35);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txbCantStock
            // 
            this.txbCantStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCantStock.Location = new System.Drawing.Point(151, 157);
            this.txbCantStock.Name = "txbCantStock";
            this.txbCantStock.Size = new System.Drawing.Size(95, 30);
            this.txbCantStock.TabIndex = 9;
            // 
            // labCosto
            // 
            this.labCosto.AutoSize = true;
            this.labCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCosto.Location = new System.Drawing.Point(293, 167);
            this.labCosto.Name = "labCosto";
            this.labCosto.Size = new System.Drawing.Size(64, 20);
            this.labCosto.TabIndex = 4;
            this.labCosto.Text = "Costo:";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAñadir.BackColor = System.Drawing.Color.HotPink;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.Color.White;
            this.btnAñadir.Location = new System.Drawing.Point(580, 43);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(124, 35);
            this.btnAñadir.TabIndex = 12;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // labStockMP
            // 
            this.labStockMP.AutoSize = true;
            this.labStockMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStockMP.Location = new System.Drawing.Point(82, 167);
            this.labStockMP.Name = "labStockMP";
            this.labStockMP.Size = new System.Drawing.Size(54, 20);
            this.labStockMP.TabIndex = 5;
            this.labStockMP.Text = "Cant:";
            // 
            // txbDescrip
            // 
            this.txbDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescrip.Location = new System.Drawing.Point(151, 71);
            this.txbDescrip.Multiline = true;
            this.txbDescrip.Name = "txbDescrip";
            this.txbDescrip.Size = new System.Drawing.Size(359, 68);
            this.txbDescrip.TabIndex = 11;
            // 
            // labpesos
            // 
            this.labpesos.AutoSize = true;
            this.labpesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpesos.Location = new System.Drawing.Point(363, 165);
            this.labpesos.Name = "labpesos";
            this.labpesos.Size = new System.Drawing.Size(21, 22);
            this.labpesos.TabIndex = 6;
            this.labpesos.Text = "$";
            // 
            // labDescrip
            // 
            this.labDescrip.AutoSize = true;
            this.labDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDescrip.Location = new System.Drawing.Point(29, 71);
            this.labDescrip.Name = "labDescrip";
            this.labDescrip.Size = new System.Drawing.Size(116, 20);
            this.labDescrip.TabIndex = 10;
            this.labDescrip.Text = "Descripción:";
            // 
            // txbCosto
            // 
            this.txbCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCosto.Location = new System.Drawing.Point(393, 157);
            this.txbCosto.Name = "txbCosto";
            this.txbCosto.Size = new System.Drawing.Size(117, 30);
            this.txbCosto.TabIndex = 8;
            // 
            // dgvMatPrima
            // 
            this.dgvMatPrima.AllowUserToOrderColumns = true;
            this.dgvMatPrima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMatPrima.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatPrima.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvMatPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatPrima.Location = new System.Drawing.Point(58, 282);
            this.dgvMatPrima.Name = "dgvMatPrima";
            this.dgvMatPrima.ReadOnly = true;
            this.dgvMatPrima.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(149)))), ((int)(((byte)(220)))));
            this.dgvMatPrima.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMatPrima.RowTemplate.Height = 24;
            this.dgvMatPrima.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvMatPrima.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatPrima.ShowCellToolTips = false;
            this.dgvMatPrima.Size = new System.Drawing.Size(827, 441);
            this.dgvMatPrima.TabIndex = 2;
            this.dgvMatPrima.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatPrima_CellContentClick);
            // 
            // Form3_3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(149)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(940, 755);
            this.Controls.Add(this.dgvMatPrima);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3_3";
            this.Text = "Form3_3";
            this.Load += new System.EventHandler(this.Form3_3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatPrima)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labpesos;
        private System.Windows.Forms.Label labStockMP;
        private System.Windows.Forms.Label labCosto;
        private System.Windows.Forms.TextBox txbCantStock;
        private System.Windows.Forms.TextBox txbCosto;
        private System.Windows.Forms.TextBox txbDescrip;
        private System.Windows.Forms.Label labDescrip;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.DataGridView dgvMatPrima;
    }
}