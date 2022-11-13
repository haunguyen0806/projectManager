using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class ReportDelay
    {
        public ReportDelay()
        {
            ReportBaggages = new HashSet<ReportBaggage>();
            ReportItineraries = new HashSet<ReportItinerary>();
        }

        public int ReportId { get; set; }
        public string Carrier { get; set; }
        public DateTime CreatedDate { get; set; }
        public string PaxName { get; set; }
        public string Address { get; set; }
        public string CityCode { get; set; }
        public string PhoneNumber { get; set; }
        public string AlternatePhone { get; set; }
        public DateTime? DateOfTravel { get; set; }
        public string NameOnTag { get; set; }
        public string TicketNo { get; set; }
        public string Notes { get; set; }
        public bool? Status { get; set; }

        public virtual ListCarrier CarrierNavigation { get; set; }
        public virtual ICollection<ReportBaggage> ReportBaggages { get; set; }
        public virtual ICollection<ReportItinerary> ReportItineraries { get; set; }
    }
}
