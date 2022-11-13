using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class ListServiceType
    {
        public ListServiceType()
        {
            Services = new HashSet<Service>();
        }

        public string ServiceType { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
