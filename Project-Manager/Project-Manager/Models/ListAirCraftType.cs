using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class ListAirCraftType
    {
        public ListAirCraftType()
        {
            ListAirCrafts = new HashSet<ListAirCraft>();
            Services = new HashSet<Service>();
        }

        public string AirCraftType { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ListAirCraft> ListAirCrafts { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
