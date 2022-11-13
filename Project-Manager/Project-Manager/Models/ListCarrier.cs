using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class ListCarrier
    {
        public ListCarrier()
        {
            LostInformations = new HashSet<LostInformation>();
            ReportDelays = new HashSet<ReportDelay>();
            Services = new HashSet<Service>();
        }

        public string Carrier { get; set; }
        public string CarrierName { get; set; }

        public virtual ICollection<LostInformation> LostInformations { get; set; }
        public virtual ICollection<ReportDelay> ReportDelays { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
