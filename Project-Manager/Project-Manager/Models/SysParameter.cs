using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class SysParameter
    {
        public string ParaName { get; set; }
        public string ParaValue { get; set; }
        public DateTime FromDate { get; set; }
        public string UserCode { get; set; }
        public string Remarks { get; set; }
    }
}
