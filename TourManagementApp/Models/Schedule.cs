using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourManagementApp.Models
{
    public class Schedule
    {
        public int ItineraryID { get; set; }
        public int TourID { get; set; }
        public int DayNumber { get; set; }
        public string Description { get; set; } = string.Empty;

        // Navigation property
        public Tours Tour { get; set; } = null!;
    }

}
