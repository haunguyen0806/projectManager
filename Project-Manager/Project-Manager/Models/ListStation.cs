using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class ListStation
    {
        public ListStation()
        {
            LostInformations = new HashSet<LostInformation>();
        }

        public string StationCode { get; set; }
        public string StationName { get; set; }

        public virtual ICollection<LostInformation> LostInformations { get; set; }
    }
}
