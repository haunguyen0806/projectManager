using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class SysRight
    {
        public string RightId { get; set; }
        public string ParentRight { get; set; }
        public string RightDescription { get; set; }
        public bool? IsDefault { get; set; }
    }
}
