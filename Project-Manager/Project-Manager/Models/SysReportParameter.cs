using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class SysReportParameter
    {
        public string ReportId { get; set; }
        public string ParaId { get; set; }
        public string ParaValue { get; set; }
        public int ParaOrder { get; set; }
    }
}
