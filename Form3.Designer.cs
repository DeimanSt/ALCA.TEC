﻿namespace Al_Soft
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
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Titulo3 = new System.Windows.Forms.Label();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.SubMenuGStock = new System.Windows.Forms.Panel();
            this.btnStockMatPrima = new System.Windows.Forms.Button();
            this.btnStockPrendas = new System.Windows.Forms.Button();
            this.pnlbarra1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnGestock = new System.Windows.Forms.Button();
            this.btnMoldesP = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictBoxMenu = new System.Windows.Forms.PictureBox();
            this.labAlSoft = new System.Windows.Forms.Label();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelmenu.SuspendLayout();
            this.SubMenuGStock.SuspendLayout();
            this.pnlbarra1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.panel1.Controls.Add(this.btnRestaurar);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.Titulo3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 45);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1203, 2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(48, 40);
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.Location = new System.Drawing.Point(1157, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1203, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(48, 40);
            this.btnMaximizar.TabIndex = 4;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1257, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Titulo3
            // 
            this.Titulo3.AutoSize = true;
            this.Titulo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo3.ForeColor = System.Drawing.Color.GhostWhite;
            this.Titulo3.Location = new System.Drawing.Point(53, 9);
            this.Titulo3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo3.Name = "Titulo3";
            this.Titulo3.Size = new System.Drawing.Size(384, 25);
            this.Titulo3.TabIndex = 0;
            this.Titulo3.Text = "Al Soft- Programa de Gestión y Diseño";
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.panelmenu.Controls.Add(this.btnGrafico);
            this.panelmenu.Controls.Add(this.SubMenuGStock);
            this.panelmenu.Controls.Add(this.btnInfo);
            this.panelmenu.Controls.Add(this.btnConfig);
            this.panelmenu.Controls.Add(this.btnGestock);
            this.panelmenu.Controls.Add(this.btnMoldesP);
            this.panelmenu.Controls.Add(this.btnPedidos);
            this.panelmenu.Controls.Add(this.btnClientes);
            this.panelmenu.Controls.Add(this.panelLogo);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 45);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(78, 755);
            this.panelmenu.TabIndex = 5;
            // 
            // btnGrafico
            // 
            this.btnGrafico.FlatAppearance.BorderSize = 0;
            this.btnGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafico.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnGrafico.Image = ((System.Drawing.Image)(resources.GetObject("btnGrafico.Image")));
            this.btnGrafico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrafico.Location = new System.Drawing.Point(0, 525);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnGrafico.Size = new System.Drawing.Size(360, 60);
            this.btnGrafico.TabIndex = 6;
            this.btnGrafico.Text = "  Control Anual";
            this.btnGrafico.UseVisualStyleBackColor = true;
            // 
            // SubMenuGStock
            // 
            this.SubMenuGStock.Controls.Add(this.btnStockMatPrima);
            this.SubMenuGStock.Controls.Add(this.btnStockPrendas);
            this.SubMenuGStock.Controls.Add(this.pnlbarra1);
            this.SubMenuGStock.Location = new System.Drawing.Point(135, 429);
            this.SubMenuGStock.Name = "SubMenuGStock";
            this.SubMenuGStock.Size = new System.Drawing.Size(225, 90);
            this.SubMenuGStock.TabIndex = 9;
            this.SubMenuGStock.Visible = false;
            // 
            // btnStockMatPrima
            // 
            this.btnStockMatPrima.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStockMatPrima.FlatAppearance.BorderSize = 0;
            this.btnStockMatPrima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockMatPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockMatPrima.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnStockMatPrima.Location = new System.Drawing.Point(6, 45);
            this.btnStockMatPrima.Name = "btnStockMatPrima";
            this.btnStockMatPrima.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnStockMatPrima.Size = new System.Drawing.Size(219, 45);
            this.btnStockMatPrima.TabIndex = 14;
            this.btnStockMatPrima.Text = "Stock Materia Prima";
            this.btnStockMatPrima.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockMatPrima.UseVisualStyleBackColor = true;
            // 
            // btnStockPrendas
            // 
            this.btnStockPrendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStockPrendas.FlatAppearance.BorderSize = 0;
            this.btnStockPrendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockPrendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockPrendas.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnStockPrendas.Location = new System.Drawing.Point(6, 0);
            this.btnStockPrendas.Name = "btnStockPrendas";
            this.btnStockPrendas.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnStockPrendas.Size = new System.Drawing.Size(219, 45);
            this.btnStockPrendas.TabIndex = 12;
            this.btnStockPrendas.Text = "Stock Prendas";
            this.btnStockPrendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockPrendas.UseVisualStyleBackColor = true;
            // 
            // pnlbarra1
            // 
            this.pnlbarra1.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlbarra1.Controls.Add(this.button2);
            this.pnlbarra1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlbarra1.Location = new System.Drawing.Point(0, 0);
            this.pnlbarra1.Name = "pnlbarra1";
            this.pnlbarra1.Size = new System.Drawing.Size(6, 90);
            this.pnlbarra1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.GhostWhite;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(60, 22);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(214, 45);
            this.button2.TabIndex = 10;
            this.button2.Text = "  Gestión de Stock";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 657);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnInfo.Size = new System.Drawing.Size(360, 60);
            this.btnInfo.TabIndex = 8;
            this.btnInfo.Text = " Información";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnConfig
            // 
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(0, 591);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnConfig.Size = new System.Drawing.Size(360, 60);
            this.btnConfig.TabIndex = 7;
            this.btnConfig.Text = "  Configuración";
            this.btnConfig.UseVisualStyleBackColor = true;
            // 
            // btnGestock
            // 
            this.btnGestock.FlatAppearance.BorderSize = 0;
            this.btnGestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestock.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnGestock.Image = ((System.Drawing.Image)(resources.GetObject("btnGestock.Image")));
            this.btnGestock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestock.Location = new System.Drawing.Point(0, 363);
            this.btnGestock.Name = "btnGestock";
            this.btnGestock.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnGestock.Size = new System.Drawing.Size(360, 60);
            this.btnGestock.TabIndex = 5;
            this.btnGestock.Text = "         Gestión de Stock";
            this.btnGestock.UseVisualStyleBackColor = true;
            this.btnGestock.Click += new System.EventHandler(this.btnGestock_Click);
            // 
            // btnMoldesP
            // 
            this.btnMoldesP.FlatAppearance.BorderSize = 0;
            this.btnMoldesP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoldesP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoldesP.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnMoldesP.Image = ((System.Drawing.Image)(resources.GetObject("btnMoldesP.Image")));
            this.btnMoldesP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoldesP.Location = new System.Drawing.Point(0, 297);
            this.btnMoldesP.Name = "btnMoldesP";
            this.btnMoldesP.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnMoldesP.Size = new System.Drawing.Size(360, 60);
            this.btnMoldesP.TabIndex = 4;
            this.btnMoldesP.Text = "            Moldes Personalizados";
            this.btnMoldesP.UseVisualStyleBackColor = true;
            this.btnMoldesP.Click += new System.EventHandler(this.btnMoldesP_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Image")));
            this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.Location = new System.Drawing.Point(0, 224);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnPedidos.Size = new System.Drawing.Size(360, 60);
            this.btnPedidos.TabIndex = 3;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(108)))), ((int)(((byte)(209)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 158);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(360, 60);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.panel3);
            this.panelLogo.Controls.Add(this.pictBoxMenu);
            this.panelLogo.Controls.Add(this.labAlSoft);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(78, 154);
            this.panelLogo.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(78, 10);
            this.panel3.TabIndex = 30;
            // 
            // pictBoxMenu
            // 
            this.pictBoxMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxMenu.Image")));
            this.pictBoxMenu.Location = new System.Drawing.Point(-9, 62);
            this.pictBoxMenu.Name = "pictBoxMenu";
            this.pictBoxMenu.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.pictBoxMenu.Size = new System.Drawing.Size(103, 84);
            this.pictBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxMenu.TabIndex = 0;
            this.pictBoxMenu.TabStop = false;
            this.pictBoxMenu.Click += new System.EventHandler(this.pictBoxMenu_Click);
            // 
            // labAlSoft
            // 
            this.labAlSoft.AutoSize = true;
            this.labAlSoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAlSoft.ForeColor = System.Drawing.Color.GhostWhite;
            this.labAlSoft.Location = new System.Drawing.Point(157, 69);
            this.labAlSoft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAlSoft.Name = "labAlSoft";
            this.labAlSoft.Size = new System.Drawing.Size(136, 25);
            this.labAlSoft.TabIndex = 29;
            this.labAlSoft.Text = "Alca.Tec TM";
            this.labAlSoft.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Location = new System.Drawing.Point(78, 45);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(1222, 755);
            this.panelcontenedor.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelmenu.ResumeLayout(false);
            this.SubMenuGStock.ResumeLayout(false);
            this.pnlbarra1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Titulo3;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictBoxMenu;
        private System.Windows.Forms.Label labAlSoft;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Button btnGestock;
        private System.Windows.Forms.Button btnMoldesP;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.Panel SubMenuGStock;
        private System.Windows.Forms.Panel pnlbarra1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStockPrendas;
        private System.Windows.Forms.Button btnStockMatPrima;
    }
}