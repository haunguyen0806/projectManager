using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class VwPerson
    {
        public string FullName { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public string GroupAddress { get; set; }
        public string Phone { get; set; }
        public byte GroupLevel { get; set; }
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string MobilePhone { get; set; }
        public string BusinessPhone { get; set; }
        public string HomePhone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int? GroupParentId { get; set; }
    }
}
