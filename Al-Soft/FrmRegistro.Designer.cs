namespace Al_Soft
{
    partial class FrmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
            this.txtContras = new System.Windows.Forms.TextBox();
            this.txtNomUsu = new System.Windows.Forms.TextBox();
            this.labNom = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtConfContras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.grBoxTipUsu = new System.Windows.Forms.GroupBox();
            this.radBtnUsu = new System.Windows.Forms.RadioButton();
            this.radBtnAdmin = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.labTituloReg = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.labContras = new System.Windows.Forms.Label();
            this.grBoxTipUsu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContras
            // 
            this.txtContras.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContras.Location = new System.Drawing.Point(317, 180);
            this.txtContras.Name = "txtContras";
            this.txtContras.Size = new System.Drawing.Size(280, 30);
            this.txtContras.TabIndex = 28;
            // 
            // txtNomUsu
            // 
            this.txtNomUsu.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomUsu.Location = new System.Drawing.Point(317, 127);
            this.txtNomUsu.Name = "txtNomUsu";
            this.txtNomUsu.Size = new System.Drawing.Size(280, 30);
            this.txtNomUsu.TabIndex = 27;
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNom.ForeColor = System.Drawing.Color.GhostWhite;
            this.labNom.Location = new System.Drawing.Point(57, 133);
            this.labNom.Name = "labNom";
            this.labNom.Size = new System.Drawing.Size(185, 24);
            this.labNom.TabIndex = 25;
            this.labNom.Text = "Ingrese un Usuario:";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(317, 285);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(280, 30);
            this.txtTel.TabIndex = 32;
            // 
            // txtConfContras
            // 
            this.txtConfContras.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfContras.Location = new System.Drawing.Point(317, 236);
            this.txtConfContras.Name = "txtConfContras";
            this.txtConfContras.Size = new System.Drawing.Size(280, 30);
            this.txtConfContras.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(59, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ingrese N° Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(59, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Confirmar Contraseña:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.HotPink;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnRegistrar.Location = new System.Drawing.Point(698, 337);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(150, 44);
            this.btnRegistrar.TabIndex = 36;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // grBoxTipUsu
            // 
            this.grBoxTipUsu.BackColor = System.Drawing.Color.Transparent;
            this.grBoxTipUsu.Controls.Add(this.radBtnUsu);
            this.grBoxTipUsu.Controls.Add(this.radBtnAdmin);
            this.grBoxTipUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grBoxTipUsu.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxTipUsu.ForeColor = System.Drawing.Color.GhostWhite;
            this.grBoxTipUsu.Location = new System.Drawing.Point(648, 127);
            this.grBoxTipUsu.Name = "grBoxTipUsu";
            this.grBoxTipUsu.Size = new System.Drawing.Size(241, 130);
            this.grBoxTipUsu.TabIndex = 37;
            this.grBoxTipUsu.TabStop = false;
            this.grBoxTipUsu.Text = "Tipo de Usuario:";
            // 
            // radBtnUsu
            // 
            this.radBtnUsu.AutoSize = true;
            this.radBtnUsu.BackColor = System.Drawing.Color.Transparent;
            this.radBtnUsu.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.radBtnUsu.FlatAppearance.BorderSize = 0;
            this.radBtnUsu.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.radBtnUsu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.radBtnUsu.ForeColor = System.Drawing.Color.GhostWhite;
            this.radBtnUsu.Location = new System.Drawing.Point(50, 85);
            this.radBtnUsu.Name = "radBtnUsu";
            this.radBtnUsu.Size = new System.Drawing.Size(100, 28);
            this.radBtnUsu.TabIndex = 1;
            this.radBtnUsu.Text = "Usuario";
            this.radBtnUsu.UseVisualStyleBackColor = false;
            // 
            // radBtnAdmin
            // 
            this.radBtnAdmin.AutoSize = true;
            this.radBtnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.radBtnAdmin.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.radBtnAdmin.FlatAppearance.BorderSize = 0;
            this.radBtnAdmin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.radBtnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.radBtnAdmin.ForeColor = System.Drawing.Color.GhostWhite;
            this.radBtnAdmin.Location = new System.Drawing.Point(50, 41);
            this.radBtnAdmin.Name = "radBtnAdmin";
            this.radBtnAdmin.Size = new System.Drawing.Size(155, 28);
            this.radBtnAdmin.TabIndex = 0;
            this.radBtnAdmin.Text = "Administrador";
            this.radBtnAdmin.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(57, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ingrese una Contraseña:";
            // 
            // labTituloReg
            // 
            this.labTituloReg.AutoSize = true;
            this.labTituloReg.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTituloReg.ForeColor = System.Drawing.Color.GhostWhite;
            this.labTituloReg.Location = new System.Drawing.Point(236, 38);
            this.labTituloReg.Name = "labTituloReg";
            this.labTituloReg.Size = new System.Drawing.Size(438, 31);
            this.labTituloReg.TabIndex = 12;
            this.labTituloReg.Text = "Formulario para Registro de Usuarios";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(896, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 35);
            this.btnSalir.TabIndex = 38;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // labContras
            // 
            this.labContras.AutoSize = true;
            this.labContras.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labContras.ForeColor = System.Drawing.Color.GhostWhite;
            this.labContras.Location = new System.Drawing.Point(57, 184);
            this.labContras.Name = "labContras";
            this.labContras.Size = new System.Drawing.Size(230, 24);
            this.labContras.TabIndex = 26;
            this.labContras.Text = "Ingrese una Contraseña:";
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(940, 500);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grBoxTipUsu);
            this.Controls.Add(this.labTituloReg);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtConfContras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContras);
            this.Controls.Add(this.txtNomUsu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labContras);
            this.Controls.Add(this.labNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistro";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmRegistro_MouseMove);
            this.grBoxTipUsu.ResumeLayout(false);
            this.grBoxTipUsu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtContras;
        private System.Windows.Forms.TextBox txtNomUsu;
        private System.Windows.Forms.Label labNom;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtConfContras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox grBoxTipUsu;
        private System.Windows.Forms.RadioButton radBtnUsu;
        private System.Windows.Forms.RadioButton radBtnAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labTituloReg;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label labContras;
    }
}