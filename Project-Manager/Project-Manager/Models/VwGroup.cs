using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class VwGroup
    {
        public int GroupId { get; set; }
        public int Odr1 { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int GroupLevel { get; set; }
        public string ChildGroupName { get; set; }
        public string ChildGroupDescription { get; set; }
        public string ChildAddress { get; set; }
        public string ChildPhone { get; set; }
        public int? ChildGroupLevel { get; set; }
        public int? ChildGroupId { get; set; }
        public int? Odr2 { get; set; }
    }
}
