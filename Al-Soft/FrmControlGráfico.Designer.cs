namespace Al_Soft
{
    partial class FrmControlGráfico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControlGráfico));
            this.gboxEgresos = new System.Windows.Forms.GroupBox();
            this.chartEgresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartIngresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gboxIngresos = new System.Windows.Forms.GroupBox();
            this.labTituloReg = new System.Windows.Forms.Label();
            this.gboxGanancia = new System.Windows.Forms.GroupBox();
            this.chartGanancias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gboxEgresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEgresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresos)).BeginInit();
            this.gboxIngresos.SuspendLayout();
            this.gboxGanancia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGanancias)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxEgresos
            // 
            this.gboxEgresos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxEgresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxEgresos.Controls.Add(this.chartEgresos);
            this.gboxEgresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.gboxEgresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.gboxEgresos.Location = new System.Drawing.Point(565, 295);
            this.gboxEgresos.Margin = new System.Windows.Forms.Padding(4);
            this.gboxEgresos.Name = "gboxEgresos";
            this.gboxEgresos.Padding = new System.Windows.Forms.Padding(4);
            this.gboxEgresos.Size = new System.Drawing.Size(361, 285);
            this.gboxEgresos.TabIndex = 38;
            this.gboxEgresos.TabStop = false;
            this.gboxEgresos.Text = "Egresos";
            // 
            // chartEgresos
            // 
            this.chartEgresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.chartEgresos.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MajorTickMark.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.Size = 0F;
            chartArea1.AxisX.MinorGrid.LineWidth = 0;
            chartArea1.AxisX.MinorTickMark.LineWidth = 0;
            chartArea1.AxisX.MinorTickMark.Size = 0F;
            chartArea1.AxisX2.MajorGrid.LineWidth = 0;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MajorTickMark.LineWidth = 0;
            chartArea1.AxisY.MajorTickMark.Size = 0F;
            chartArea1.AxisY2.MajorGrid.LineWidth = 0;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            chartArea1.Name = "ChartArea1";
            this.chartEgresos.ChartAreas.Add(chartArea1);
            this.chartEgresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartEgresos.Location = new System.Drawing.Point(4, 31);
            this.chartEgresos.Margin = new System.Windows.Forms.Padding(4);
            this.chartEgresos.Name = "chartEgresos";
            this.chartEgresos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Name = "Puntos";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Lineas";
            this.chartEgresos.Series.Add(series1);
            this.chartEgresos.Series.Add(series2);
            this.chartEgresos.Size = new System.Drawing.Size(353, 250);
            this.chartEgresos.TabIndex = 36;
            this.chartEgresos.Text = "chartegreso";
            // 
            // chartIngresos
            // 
            this.chartIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.chartIngresos.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisX.MajorTickMark.LineWidth = 0;
            chartArea2.AxisX.MajorTickMark.Size = 0F;
            chartArea2.AxisX.MinorGrid.LineWidth = 0;
            chartArea2.AxisX.MinorTickMark.LineWidth = 0;
            chartArea2.AxisX.MinorTickMark.Size = 0F;
            chartArea2.AxisX2.MajorGrid.LineWidth = 0;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LineWidth = 0;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.MajorTickMark.LineWidth = 0;
            chartArea2.AxisY.MajorTickMark.Size = 0F;
            chartArea2.AxisY2.MajorGrid.LineWidth = 0;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            chartArea2.Name = "ChartArea1";
            this.chartIngresos.ChartAreas.Add(chartArea2);
            this.chartIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartIngresos.Location = new System.Drawing.Point(4, 31);
            this.chartIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.chartIngresos.Name = "chartIngresos";
            this.chartIngresos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series3.BackSecondaryColor = System.Drawing.Color.MediumPurple;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.Indigo;
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.Indigo;
            series3.MarkerBorderWidth = 0;
            series3.MarkerColor = System.Drawing.Color.Indigo;
            series3.MarkerSize = 8;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Puntos";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.MarkerSize = 10;
            series4.Name = "Lineas";
            this.chartIngresos.Series.Add(series3);
            this.chartIngresos.Series.Add(series4);
            this.chartIngresos.Size = new System.Drawing.Size(353, 250);
            this.chartIngresos.TabIndex = 35;
            this.chartIngresos.Text = "chartIngresos";
            // 
            // gboxIngresos
            // 
            this.gboxIngresos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxIngresos.Controls.Add(this.chartIngresos);
            this.gboxIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.gboxIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.gboxIngresos.Location = new System.Drawing.Point(565, 13);
            this.gboxIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.gboxIngresos.Name = "gboxIngresos";
            this.gboxIngresos.Padding = new System.Windows.Forms.Padding(4);
            this.gboxIngresos.Size = new System.Drawing.Size(361, 285);
            this.gboxIngresos.TabIndex = 39;
            this.gboxIngresos.TabStop = false;
            this.gboxIngresos.Text = "Ingresos";
            // 
            // labTituloReg
            // 
            this.labTituloReg.AutoSize = true;
            this.labTituloReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F, System.Drawing.FontStyle.Bold);
            this.labTituloReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.labTituloReg.Location = new System.Drawing.Point(38, 29);
            this.labTituloReg.Name = "labTituloReg";
            this.labTituloReg.Size = new System.Drawing.Size(446, 39);
            this.labTituloReg.TabIndex = 40;
            this.labTituloReg.Text = "Control Grafico De Ventas";
            // 
            // gboxGanancia
            // 
            this.gboxGanancia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gboxGanancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.gboxGanancia.Controls.Add(this.chartGanancias);
            this.gboxGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.gboxGanancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.gboxGanancia.Location = new System.Drawing.Point(13, 131);
            this.gboxGanancia.Margin = new System.Windows.Forms.Padding(4);
            this.gboxGanancia.Name = "gboxGanancia";
            this.gboxGanancia.Padding = new System.Windows.Forms.Padding(4);
            this.gboxGanancia.Size = new System.Drawing.Size(544, 488);
            this.gboxGanancia.TabIndex = 41;
            this.gboxGanancia.TabStop = false;
            this.gboxGanancia.Text = "GANANCIAS";
            // 
            // chartGanancias
            // 
            this.chartGanancias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.chartGanancias.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.MajorGrid.LineWidth = 0;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisX.MajorTickMark.LineWidth = 0;
            chartArea3.AxisX.MajorTickMark.Size = 0F;
            chartArea3.AxisX.MinorGrid.LineWidth = 0;
            chartArea3.AxisX.MinorTickMark.LineWidth = 0;
            chartArea3.AxisX.MinorTickMark.Size = 0F;
            chartArea3.AxisX2.MajorGrid.LineWidth = 0;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.LineWidth = 0;
            chartArea3.AxisY.MajorTickMark.Enabled = false;
            chartArea3.AxisY.MajorTickMark.LineWidth = 0;
            chartArea3.AxisY.MajorTickMark.Size = 0F;
            chartArea3.AxisY2.MajorGrid.LineWidth = 0;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            chartArea3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            chartArea3.Name = "ChartArea1";
            this.chartGanancias.ChartAreas.Add(chartArea3);
            this.chartGanancias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartGanancias.Location = new System.Drawing.Point(4, 31);
            this.chartGanancias.Margin = new System.Windows.Forms.Padding(4);
            this.chartGanancias.Name = "chartGanancias";
            series5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series5.BackSecondaryColor = System.Drawing.Color.Plum;
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Color = System.Drawing.Color.SlateBlue;
            series5.Legend = "Legend1";
            series5.MarkerBorderColor = System.Drawing.Color.Indigo;
            series5.MarkerBorderWidth = 0;
            series5.MarkerColor = System.Drawing.Color.Indigo;
            series5.MarkerSize = 0;
            series5.Name = "Puntos";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.MarkerBorderWidth = 5;
            series6.Name = "Lineas";
            this.chartGanancias.Series.Add(series5);
            this.chartGanancias.Series.Add(series6);
            this.chartGanancias.Size = new System.Drawing.Size(536, 453);
            this.chartGanancias.TabIndex = 35;
            this.chartGanancias.Text = "chartganancias";
            // 
            // FrmControlGráfico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(930, 718);
            this.Controls.Add(this.gboxGanancia);
            this.Controls.Add(this.labTituloReg);
            this.Controls.Add(this.gboxIngresos);
            this.Controls.Add(this.gboxEgresos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmControlGráfico";
            this.Text = "FrmControlGráfico";
            this.gboxEgresos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEgresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresos)).EndInit();
            this.gboxIngresos.ResumeLayout(false);
            this.gboxGanancia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGanancias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gboxEgresos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEgresos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIngresos;
        private System.Windows.Forms.GroupBox gboxIngresos;
        private System.Windows.Forms.Label labTituloReg;
        private System.Windows.Forms.GroupBox gboxGanancia;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGanancias;
    }
}