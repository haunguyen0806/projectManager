using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class Service
    {
        public int ServiceId { get; set; }
        public DateTime? ServiceDate { get; set; }
        public bool? Subscriber { get; set; }
        public string Carrier { get; set; }
        public string FlightNo { get; set; }
        public string Route { get; set; }
        public string AirCraftType { get; set; }
        public string RegistrationNo { get; set; }
        public float? Mtow { get; set; }
        public string TimeGraft1st { get; set; }
        public string TimeWithdraw1st { get; set; }
        public string TimeGraft2nd { get; set; }
        public string TimeWithdraw2nd { get; set; }
        public string ServiceType { get; set; }
        public float? Charge { get; set; }
        public string ChargeCurr { get; set; }
        public float? AddCharge { get; set; }
        public string AddChargeCurr { get; set; }
        public string Notes { get; set; }

        public virtual ListAirCraftType AirCraftTypeNavigation { get; set; }
        public virtual ListCarrier CarrierNavigation { get; set; }
        public virtual ListServiceType ServiceTypeNavigation { get; set; }
    }
}
