using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class ListAirCraft
    {
        public int AirCraftId { get; set; }
        public string AirCraftType { get; set; }
        public string RegistrationNo { get; set; }
        public string Carrier { get; set; }
        public float? Mtow { get; set; }
        public int? Seats { get; set; }

        public virtual ListAirCraftType AirCraftTypeNavigation { get; set; }
    }
}
