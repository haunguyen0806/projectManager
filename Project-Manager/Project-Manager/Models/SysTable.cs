using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class SysTable
    {
        public string TableAlias { get; set; }
        public string TableName { get; set; }
        public bool CanModify { get; set; }
    }
}
