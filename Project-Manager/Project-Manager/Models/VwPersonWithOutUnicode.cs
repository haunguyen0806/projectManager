using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class VwPersonWithOutUnicode
    {
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string MobilePhone { get; set; }
        public string BusinessPhone { get; set; }
        public string HomePhone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string FullName2 { get; set; }
        public string JobTitle2 { get; set; }
        public int? GroupId { get; set; }
        public int Sort { get; set; }
    }
}
