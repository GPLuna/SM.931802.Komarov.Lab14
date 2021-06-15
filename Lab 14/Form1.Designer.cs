
namespace Lab_14
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mean = new System.Windows.Forms.NumericUpDown();
            this.variance = new System.Windows.Forms.NumericUpDown();
            this.size = new System.Windows.Forms.NumericUpDown();
            this.average = new System.Windows.Forms.TextBox();
            this.var = new System.Windows.Forms.TextBox();
            this.average_error = new System.Windows.Forms.TextBox();
            this.variance_error = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.mean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // mean
            // 
            this.mean.DecimalPlaces = 2;
            this.mean.Location = new System.Drawing.Point(137, 12);
            this.mean.Name = "mean";
            this.mean.Size = new System.Drawing.Size(120, 22);
            this.mean.TabIndex = 0;
            this.mean.Value = new decimal(new int[] {
            80,
            0,
            0,
            131072});
            // 
            // variance
            // 
            this.variance.DecimalPlaces = 2;
            this.variance.Location = new System.Drawing.Point(137, 61);
            this.variance.Name = "variance";
            this.variance.Size = new System.Drawing.Size(120, 22);
            this.variance.TabIndex = 1;
            this.variance.Value = new decimal(new int[] {
            45,
            0,
            0,
            131072});
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(137, 113);
            this.size.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(120, 22);
            this.size.TabIndex = 2;
            this.size.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // average
            // 
            this.average.Location = new System.Drawing.Point(393, 22);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(100, 22);
            this.average.TabIndex = 3;
            // 
            // var
            // 
            this.var.Location = new System.Drawing.Point(393, 72);
            this.var.Name = "var";
            this.var.Size = new System.Drawing.Size(100, 22);
            this.var.TabIndex = 4;
            // 
            // average_error
            // 
            this.average_error.Location = new System.Drawing.Point(593, 23);
            this.average_error.Name = "average_error";
            this.average_error.Size = new System.Drawing.Size(100, 22);
            this.average_error.TabIndex = 5;
            // 
            // variance_error
            // 
            this.variance_error.Location = new System.Drawing.Point(593, 74);
            this.variance_error.Name = "variance_error";
            this.variance_error.Size = new System.Drawing.Size(100, 22);
            this.variance_error.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Average";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Variance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Error, %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Error, %";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(764, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 73);
            this.button1.TabIndex = 12;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(53, 159);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Purple;
            series1.Legend = "Legend1";
            series1.Name = "freq";
            series1.YValuesPerPoint = 2;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "distr";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(833, 355);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 526);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.variance_error);
            this.Controls.Add(this.average_error);
            this.Controls.Add(this.var);
            this.Controls.Add(this.average);
            this.Controls.Add(this.size);
            this.Controls.Add(this.variance);
            this.Controls.Add(this.mean);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown mean;
        private System.Windows.Forms.NumericUpDown variance;
        private System.Windows.Forms.NumericUpDown size;
        private System.Windows.Forms.TextBox average;
        private System.Windows.Forms.TextBox var;
        private System.Windows.Forms.TextBox average_error;
        private System.Windows.Forms.TextBox variance_error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

