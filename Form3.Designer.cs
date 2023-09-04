namespace Al_Soft
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Titulo3 = new System.Windows.Forms.Label();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.butInform = new System.Windows.Forms.Button();
            this.butConfig = new System.Windows.Forms.Button();
            this.butControlA = new System.Windows.Forms.Button();
            this.butGestionStock = new System.Windows.Forms.Button();
            this.butMoldes = new System.Windows.Forms.Button();
            this.butPedidos = new System.Windows.Forms.Button();
            this.butCliente = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.PictboxLogo = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.Titulo3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 52);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.btnMinimizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.Location = new System.Drawing.Point(1235, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(55, 52);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.btnMaximizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = global::Al_Soft.Properties.Resources.Maximizar;
            this.btnMaximizar.Location = new System.Drawing.Point(1290, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(55, 52);
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.btnSalir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1345, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(55, 52);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Titulo3
            // 
            this.Titulo3.AutoSize = true;
            this.Titulo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo3.ForeColor = System.Drawing.Color.GhostWhite;
            this.Titulo3.Location = new System.Drawing.Point(32, 11);
            this.Titulo3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo3.Name = "Titulo3";
            this.Titulo3.Size = new System.Drawing.Size(384, 25);
            this.Titulo3.TabIndex = 0;
            this.Titulo3.Text = "Al Soft- Programa de Gestión y Diseño";
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.panelmenu.Controls.Add(this.butInform);
            this.panelmenu.Controls.Add(this.butConfig);
            this.panelmenu.Controls.Add(this.butControlA);
            this.panelmenu.Controls.Add(this.butGestionStock);
            this.panelmenu.Controls.Add(this.butMoldes);
            this.panelmenu.Controls.Add(this.butPedidos);
            this.panelmenu.Controls.Add(this.butCliente);
            this.panelmenu.Controls.Add(this.btnClientes);
            this.panelmenu.Controls.Add(this.panelLogo);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 52);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(348, 748);
            this.panelmenu.TabIndex = 16;
            // 
            // butInform
            // 
            this.butInform.Dock = System.Windows.Forms.DockStyle.Top;
            this.butInform.FlatAppearance.BorderSize = 0;
            this.butInform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInform.ForeColor = System.Drawing.Color.GhostWhite;
            this.butInform.Image = global::Al_Soft.Properties.Resources.icono_acercade;
            this.butInform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butInform.Location = new System.Drawing.Point(0, 578);
            this.butInform.Name = "butInform";
            this.butInform.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.butInform.Size = new System.Drawing.Size(348, 65);
            this.butInform.TabIndex = 24;
            this.butInform.Text = "          Información";
            this.butInform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butInform.UseVisualStyleBackColor = true;
            // 
            // butConfig
            // 
            this.butConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.butConfig.FlatAppearance.BorderSize = 0;
            this.butConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConfig.ForeColor = System.Drawing.Color.GhostWhite;
            this.butConfig.Image = global::Al_Soft.Properties.Resources.icons8_edit_production_order_40;
            this.butConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butConfig.Location = new System.Drawing.Point(0, 513);
            this.butConfig.Name = "butConfig";
            this.butConfig.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.butConfig.Size = new System.Drawing.Size(348, 65);
            this.butConfig.TabIndex = 23;
            this.butConfig.Text = "          Configuración";
            this.butConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butConfig.UseVisualStyleBackColor = true;
            // 
            // butControlA
            // 
            this.butControlA.Dock = System.Windows.Forms.DockStyle.Top;
            this.butControlA.FlatAppearance.BorderSize = 0;
            this.butControlA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butControlA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butControlA.ForeColor = System.Drawing.Color.GhostWhite;
            this.butControlA.Image = global::Al_Soft.Properties.Resources.icons8_grafico_economico_40;
            this.butControlA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butControlA.Location = new System.Drawing.Point(0, 448);
            this.butControlA.Name = "butControlA";
            this.butControlA.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.butControlA.Size = new System.Drawing.Size(348, 65);
            this.butControlA.TabIndex = 22;
            this.butControlA.Text = "          Control Anual";
            this.butControlA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butControlA.UseVisualStyleBackColor = true;
            // 
            // butGestionStock
            // 
            this.butGestionStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.butGestionStock.FlatAppearance.BorderSize = 0;
            this.butGestionStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butGestionStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGestionStock.ForeColor = System.Drawing.Color.GhostWhite;
            this.butGestionStock.Image = global::Al_Soft.Properties.Resources.icons8_edit_product_40;
            this.butGestionStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butGestionStock.Location = new System.Drawing.Point(0, 383);
            this.butGestionStock.Name = "butGestionStock";
            this.butGestionStock.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.butGestionStock.Size = new System.Drawing.Size(348, 65);
            this.butGestionStock.TabIndex = 21;
            this.butGestionStock.Text = "          Gestión de Stock";
            this.butGestionStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butGestionStock.UseVisualStyleBackColor = true;
            // 
            // butMoldes
            // 
            this.butMoldes.Dock = System.Windows.Forms.DockStyle.Top;
            this.butMoldes.FlatAppearance.BorderSize = 0;
            this.butMoldes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMoldes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMoldes.ForeColor = System.Drawing.Color.GhostWhite;
            this.butMoldes.Image = global::Al_Soft.Properties.Resources.icons8_diseño_40;
            this.butMoldes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butMoldes.Location = new System.Drawing.Point(0, 318);
            this.butMoldes.Name = "butMoldes";
            this.butMoldes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.butMoldes.Size = new System.Drawing.Size(348, 65);
            this.butMoldes.TabIndex = 20;
            this.butMoldes.Text = "          Moldes Personalizados";
            this.butMoldes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butMoldes.UseVisualStyleBackColor = true;
            // 
            // butPedidos
            // 
            this.butPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.butPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.butPedidos.FlatAppearance.BorderSize = 0;
            this.butPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPedidos.ForeColor = System.Drawing.Color.GhostWhite;
            this.butPedidos.Image = global::Al_Soft.Properties.Resources.icons8_abrir_carpeta_40;
            this.butPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butPedidos.Location = new System.Drawing.Point(0, 253);
            this.butPedidos.Name = "butPedidos";
            this.butPedidos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.butPedidos.Size = new System.Drawing.Size(348, 65);
            this.butPedidos.TabIndex = 19;
            this.butPedidos.Text = "          Pedidos";
            this.butPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butPedidos.UseVisualStyleBackColor = false;
            // 
            // butCliente
            // 
            this.butCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.butCliente.FlatAppearance.BorderSize = 0;
            this.butCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.butCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(85)))), ((int)(((byte)(155)))));
            this.butCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCliente.ForeColor = System.Drawing.Color.GhostWhite;
            this.butCliente.Image = global::Al_Soft.Properties.Resources.icons8_cliente_40;
            this.butCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCliente.Location = new System.Drawing.Point(0, 188);
            this.butCliente.Name = "butCliente";
            this.butCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.butCliente.Size = new System.Drawing.Size(348, 65);
            this.butCliente.TabIndex = 18;
            this.butCliente.Text = "          Clientes ";
            this.butCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCliente.UseVisualStyleBackColor = true;
            this.butCliente.Click += new System.EventHandler(this.butCliente_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClientes.Location = new System.Drawing.Point(0, 178);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(348, 10);
            this.btnClientes.TabIndex = 17;
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.panelLogo.Controls.Add(this.iconButton1);
            this.panelLogo.Controls.Add(this.PictboxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(348, 178);
            this.panelLogo.TabIndex = 16;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.AutoSize = true;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.iconButton1.IconColor = System.Drawing.Color.GhostWhite;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 55;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconButton1.Location = new System.Drawing.Point(245, 114);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(72, 61);
            this.iconButton1.TabIndex = 18;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // PictboxLogo
            // 
            this.PictboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictboxLogo.Image")));
            this.PictboxLogo.Location = new System.Drawing.Point(99, 37);
            this.PictboxLogo.Margin = new System.Windows.Forms.Padding(1);
            this.PictboxLogo.Name = "PictboxLogo";
            this.PictboxLogo.Size = new System.Drawing.Size(106, 98);
            this.PictboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictboxLogo.TabIndex = 17;
            this.PictboxLogo.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(348, 52);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1052, 748);
            this.panelContenedor.TabIndex = 17;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(600, 800);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictboxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Titulo3;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button butPedidos;
        private System.Windows.Forms.Button butCliente;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button butControlA;
        private System.Windows.Forms.Button butGestionStock;
        private System.Windows.Forms.Button butMoldes;
        private System.Windows.Forms.Button butInform;
        private System.Windows.Forms.Button butConfig;
        private System.Windows.Forms.Panel panelContenedor;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.PictureBox PictboxLogo;
    }
}