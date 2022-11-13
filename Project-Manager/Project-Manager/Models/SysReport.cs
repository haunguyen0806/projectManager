using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class SysReport
    {
        public string ReportId { get; set; }
        public string ReportTitle { get; set; }
        public string ReportFile { get; set; }
        public string Status { get; set; }
    }
}
