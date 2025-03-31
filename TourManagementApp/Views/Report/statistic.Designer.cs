namespace TourManagementApp.Views.Report
{
    partial class statistic
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            columnChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            cbb_year = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)columnChart).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            SuspendLayout();
            // 
            // columnChart
            // 
            chartArea1.Name = "ChartArea1";
            columnChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            columnChart.Legends.Add(legend1);
            columnChart.Location = new Point(36, 59);
            columnChart.Name = "columnChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            columnChart.Series.Add(series1);
            columnChart.Size = new Size(390, 290);
            columnChart.TabIndex = 0;
            columnChart.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 352);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 1;
            label1.Text = "Biểu đồ doanh thu";
            // 
            // cbb_year
            // 
            cbb_year.FormattingEnabled = true;
            cbb_year.Items.AddRange(new object[] { "2022", "2023", "2024", "2025", "2026", "2027", "2028" });
            cbb_year.Location = new Point(115, 10);
            cbb_year.Name = "cbb_year";
            cbb_year.Size = new Size(151, 28);
            cbb_year.TabIndex = 2;
            cbb_year.SelectedIndexChanged += cbb_year_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 10);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 3;
            label2.Text = "Năm";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(chart);
            panel1.Controls.Add(cbb_year);
            panel1.Controls.Add(columnChart);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 396);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(633, 352);
            label3.Name = "label3";
            label3.Size = new Size(217, 28);
            label3.TabIndex = 5;
            label3.Text = "Thống kê theo loại tour";
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart.Legends.Add(legend2);
            chart.Location = new Point(538, 59);
            chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart.Series.Add(series2);
            chart.Size = new Size(355, 290);
            chart.TabIndex = 4;
            chart.Text = "chart1";
            // 
            // statistic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(987, 432);
            Controls.Add(panel1);
            Name = "statistic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "statistic";
            Load += statistic_Load;
            ((System.ComponentModel.ISupportInitialize)columnChart).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart columnChart;
        private Label label1;
        private ComboBox cbb_year;
        private Label label2;
        private Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Label label3;
    }
}