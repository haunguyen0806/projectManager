using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class LostInformation
    {
        public LostInformation()
        {
            TagDetails = new HashSet<TagDetail>();
        }

        public string FileNo { get; set; }
        public string Carrier { get; set; }
        public string PaxName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ReasonCode { get; set; }
        public string FaultStation { get; set; }
        public int? TotalPieces { get; set; }
        public string Notes { get; set; }
        public bool? Status { get; set; }

        public virtual ListCarrier CarrierNavigation { get; set; }
        public virtual ListStation FaultStationNavigation { get; set; }
        public virtual ListReason ReasonCodeNavigation { get; set; }
        public virtual ICollection<TagDetail> TagDetails { get; set; }
    }
}
