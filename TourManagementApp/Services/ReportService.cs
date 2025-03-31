using System;
using System.Collections.Generic;
using TourManagementApp.Models;
using TourManagementApp.Repositories;

namespace TourManagementApp.Services
{
    public class ReportService
    {
        private readonly ReportRepository reportRepository = new ReportRepository();
        public Dictionary<string, int> GetTourTypeCounts()
        {
            return reportRepository.GetTourTypeCounts();
        }
        public Dictionary<int, int> GetTotalAmountByMonth(int year)
        {
            return reportRepository.GetTotalAmountByMonth(year);
        }


        public Dictionary<string, int> GetStatistics(DateTime startDate, DateTime endDate)
        {
            return reportRepository.GetStatistics(startDate, endDate);
        }

        public List<Schedule> GetSchedule(DateTime startDate, DateTime endDate)
        {
            return reportRepository.GetSchedule(startDate, endDate);
        }
    }
}
