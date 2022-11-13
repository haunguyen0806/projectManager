using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class ListDelivery
    {
        public ListDelivery()
        {
            TagDetails = new HashSet<TagDetail>();
        }

        public string DeliveryType { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TagDetail> TagDetails { get; set; }
    }
}
