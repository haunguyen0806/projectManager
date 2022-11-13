using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class ListReason
    {
        public ListReason()
        {
            LostInformations = new HashSet<LostInformation>();
        }

        public string ReasonCode { get; set; }
        public string Reason4 { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LostInformation> LostInformations { get; set; }
    }
}
