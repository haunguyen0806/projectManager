using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class ListOfFee
    {
        public string DeliveryBy { get; set; }
        public byte TagOrder { get; set; }
        public float? Charge { get; set; }
        public string ChargeCurr { get; set; }
        public float? ExpressFee { get; set; }
        public string ExpressFeeCurr { get; set; }
        public float? FeeAddRate { get; set; }
        public float? AddCharge { get; set; }
        public string AddChargeCurr { get; set; }
        public float? Interim { get; set; }
        public string InterimCurr { get; set; }
    }
}
