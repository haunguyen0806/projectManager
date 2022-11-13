using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class ReportItinerary
    {
        public int ItineraryId { get; set; }
        public int ReportId { get; set; }
        public string FromPort { get; set; }
        public string ToPort { get; set; }
        public string Carrier { get; set; }
        public string FlightNo { get; set; }

        public virtual ReportDelay Report { get; set; }
    }
}
