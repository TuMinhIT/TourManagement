using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TourManagementApp.Services;

namespace TourManagementApp.Views.Report
{
    public partial class statistic : Form
    {
        private ReportService reportService = new ReportService();
        private int year = 2025;
        public statistic()
        {
            InitializeComponent();
            LoadColumnChart();
            LoadPieChart();
        }

        private void statistic_Load(object sender, EventArgs e)
        {
            cbb_year.SelectedText = year.ToString();
        }


        private void LoadColumnChart()
        {
            Dictionary<int, int> data = reportService.GetTotalAmountByMonth(year);

            columnChart.Series.Clear();
            columnChart.Titles.Clear();
            columnChart.ChartAreas.Clear();


            columnChart.Titles.Add("Biểu đồ cột - Thống kê doanh thu theo tháng");


            ChartArea chartArea = new ChartArea();
            columnChart.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                Name = "Doanh thu ($)",
                ChartType = SeriesChartType.Column
            };
            foreach (var item in data)
            {
                series.Points.AddXY(item.Key, item.Value);

            }

            columnChart.Series.Add(series);
            series.IsValueShownAsLabel = true;
        }

        private void LoadPieChart()
        {
            Dictionary<string, int> data = reportService.GetTourTypeCounts();
            Series series = new Series
            {
                Name = "Thống kê",
                ChartType = SeriesChartType.Pie
            };

            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Titles.Add("Biểu đồ tròn - Thống kê số loại tour");
            foreach (var item in data)
            {
                series.Points.AddXY(item.Key, item.Value);
            }
            chart.Series.Add(series);
            series.IsValueShownAsLabel = true;
        }

        private void cbb_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            year = int .Parse(cbb_year.Text);
            LoadColumnChart();
        }

    }

}
