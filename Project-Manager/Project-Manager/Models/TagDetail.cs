using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class TagDetail
    {
        public int TagId { get; set; }
        public string FileNo { get; set; }
        public string TagNo { get; set; }
        public byte? TagOrder { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string DeliveryBy { get; set; }
        public string Notes { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? Quantity { get; set; }
        public float? Charge { get; set; }
        public string ChargeCurr { get; set; }
        public float? ExpressFee { get; set; }
        public string ExpressFeeCurr { get; set; }
        public float? FeeAddRate { get; set; }
        public float? AddCharge { get; set; }
        public string AddChargeCurr { get; set; }
        public float? Interim { get; set; }
        public string InterimCurr { get; set; }
        public int? InterimRate { get; set; }
        public bool? Status { get; set; }

        public virtual ListDelivery DeliveryByNavigation { get; set; }
        public virtual LostInformation FileNoNavigation { get; set; }
    }
}
