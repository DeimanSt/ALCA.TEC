namespace Al_Soft
{
    partial class Form3_1
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
            FontAwesome.Sharp.IconPictureBox iconLimpiar;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labNom = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.txbTel = new System.Windows.Forms.TextBox();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.txbCedula = new System.Windows.Forms.TextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.labFecha = new System.Windows.Forms.Label();
            this.labCI = new System.Windows.Forms.Label();
            this.labTel = new System.Windows.Forms.Label();
            this.labDir = new System.Windows.Forms.Label();
            this.labApell = new System.Windows.Forms.Label();
            this.dataGridCliente = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            iconLimpiar = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(iconLimpiar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconLimpiar
            // 
            iconLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            iconLimpiar.BackColor = System.Drawing.Color.Transparent;
            iconLimpiar.ForeColor = System.Drawing.Color.AliceBlue;
            iconLimpiar.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            iconLimpiar.IconColor = System.Drawing.Color.AliceBlue;
            iconLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconLimpiar.IconSize = 50;
            iconLimpiar.Location = new System.Drawing.Point(1064, 82);
            iconLimpiar.Name = "iconLimpiar";
            iconLimpiar.Size = new System.Drawing.Size(50, 50);
            iconLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            iconLimpiar.TabIndex = 12;
            iconLimpiar.TabStop = false;
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labNom.ForeColor = System.Drawing.Color.White;
            this.labNom.Location = new System.Drawing.Point(40, 57);
            this.labNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNom.Name = "labNom";
            this.labNom.Size = new System.Drawing.Size(85, 22);
            this.labNom.TabIndex = 0;
            this.labNom.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(iconLimpiar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.dateTimeFecha);
            this.groupBox1.Controls.Add(this.txbTel);
            this.groupBox1.Controls.Add(this.txbDireccion);
            this.groupBox1.Controls.Add(this.txbCedula);
            this.groupBox1.Controls.Add(this.txbApellido);
            this.groupBox1.Controls.Add(this.txbNombre);
            this.groupBox1.Controls.Add(this.labFecha);
            this.groupBox1.Controls.Add(this.labCI);
            this.groupBox1.Controls.Add(this.labTel);
            this.groupBox1.Controls.Add(this.labDir);
            this.groupBox1.Controls.Add(this.labApell);
            this.groupBox1.Controls.Add(this.labNom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(31, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1169, 223);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRAR CLIENTE:";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModificar.BackColor = System.Drawing.Color.HotPink;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnModificar.Location = new System.Drawing.Point(894, 126);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 44);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.BackColor = System.Drawing.Color.HotPink;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnGuardar.Location = new System.Drawing.Point(894, 47);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 44);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimeFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFecha.CalendarForeColor = System.Drawing.Color.HotPink;
            this.dateTimeFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFecha.Location = new System.Drawing.Point(574, 142);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(245, 28);
            this.dateTimeFecha.TabIndex = 11;
            // 
            // txbTel
            // 
            this.txbTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTel.Location = new System.Drawing.Point(574, 91);
            this.txbTel.Name = "txbTel";
            this.txbTel.Size = new System.Drawing.Size(245, 28);
            this.txbTel.TabIndex = 10;
            // 
            // txbDireccion
            // 
            this.txbDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDireccion.Location = new System.Drawing.Point(574, 46);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(245, 28);
            this.txbDireccion.TabIndex = 9;
            // 
            // txbCedula
            // 
            this.txbCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCedula.Location = new System.Drawing.Point(138, 142);
            this.txbCedula.Name = "txbCedula";
            this.txbCedula.Size = new System.Drawing.Size(273, 28);
            this.txbCedula.TabIndex = 8;
            // 
            // txbApellido
            // 
            this.txbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApellido.Location = new System.Drawing.Point(138, 92);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(273, 28);
            this.txbApellido.TabIndex = 7;
            // 
            // txbNombre
            // 
            this.txbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(138, 47);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(273, 21);
            this.txbNombre.TabIndex = 6;
            // 
            // labFecha
            // 
            this.labFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labFecha.AutoSize = true;
            this.labFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labFecha.ForeColor = System.Drawing.Color.White;
            this.labFecha.Location = new System.Drawing.Point(467, 149);
            this.labFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(71, 22);
            this.labFecha.TabIndex = 5;
            this.labFecha.Text = "Fecha:";
            // 
            // labCI
            // 
            this.labCI.AutoSize = true;
            this.labCI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labCI.ForeColor = System.Drawing.Color.White;
            this.labCI.Location = new System.Drawing.Point(46, 148);
            this.labCI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCI.Name = "labCI";
            this.labCI.Size = new System.Drawing.Size(79, 22);
            this.labCI.TabIndex = 4;
            this.labCI.Text = "Cédula:";
            // 
            // labTel
            // 
            this.labTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labTel.AutoSize = true;
            this.labTel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labTel.ForeColor = System.Drawing.Color.White;
            this.labTel.Location = new System.Drawing.Point(467, 97);
            this.labTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTel.Name = "labTel";
            this.labTel.Size = new System.Drawing.Size(95, 22);
            this.labTel.TabIndex = 3;
            this.labTel.Text = "Teléfono:";
            // 
            // labDir
            // 
            this.labDir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labDir.AutoSize = true;
            this.labDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labDir.ForeColor = System.Drawing.Color.White;
            this.labDir.Location = new System.Drawing.Point(467, 52);
            this.labDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDir.Name = "labDir";
            this.labDir.Size = new System.Drawing.Size(100, 22);
            this.labDir.TabIndex = 2;
            this.labDir.Text = "Dirección:";
            // 
            // labApell
            // 
            this.labApell.AutoSize = true;
            this.labApell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labApell.ForeColor = System.Drawing.Color.White;
            this.labApell.Location = new System.Drawing.Point(46, 98);
            this.labApell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labApell.Name = "labApell";
            this.labApell.Size = new System.Drawing.Size(88, 22);
            this.labApell.TabIndex = 1;
            this.labApell.Text = "Apellido:";
            // 
            // dataGridCliente
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.dataGridCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCliente.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCliente.Location = new System.Drawing.Point(31, 363);
            this.dataGridCliente.Name = "dataGridCliente";
            this.dataGridCliente.ReadOnly = true;
            this.dataGridCliente.RowHeadersWidth = 51;
            this.dataGridCliente.RowTemplate.Height = 24;
            this.dataGridCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCliente.Size = new System.Drawing.Size(1169, 364);
            this.dataGridCliente.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.Controls.Add(this.txbBuscar);
            this.panel1.Controls.Add(this.lblBuscar);
            this.panel1.Location = new System.Drawing.Point(31, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 58);
            this.panel1.TabIndex = 3;
            // 
            // txbBuscar
            // 
            this.txbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscar.Location = new System.Drawing.Point(114, 17);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(394, 28);
            this.txbBuscar.TabIndex = 20;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(17, 17);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(78, 22);
            this.lblBuscar.TabIndex = 19;
            this.lblBuscar.Text = "Buscar:";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar1.Location = new System.Drawing.Point(31, 706);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(1169, 21);
            this.hScrollBar1.TabIndex = 4;
            // 
            // Form3_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1232, 794);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridCliente);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3_1";
            this.Load += new System.EventHandler(this.Form3_1_Load);
            ((System.ComponentModel.ISupportInitialize)(iconLimpiar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labDir;
        private System.Windows.Forms.Label labApell;
        private System.Windows.Forms.Label labFecha;
        private System.Windows.Forms.Label labCI;
        private System.Windows.Forms.Label labTel;
        private System.Windows.Forms.DateTimePicker dateTimeFecha;
        private System.Windows.Forms.TextBox txbTel;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.TextBox txbCedula;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dataGridCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.TextBox txbBuscar;
    }
}