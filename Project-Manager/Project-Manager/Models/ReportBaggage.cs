using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class ReportBaggage
    {
        public int BaggageId { get; set; }
        public int ReportId { get; set; }
        public string TagNo { get; set; }
        public string Color { get; set; }
        public byte? TypeNo { get; set; }

        public virtual ReportDelay Report { get; set; }
    }
}
