using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class Person
    {
        public int PersonId { get; set; }
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string MobilePhone { get; set; }
        public string BusinessPhone { get; set; }
        public string HomePhone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int? GroupId { get; set; }
        public string UserId { get; set; }
        public int? Status { get; set; }
        public long? SortBy { get; set; }
        public int? Hrmid { get; set; }
        public int? PositionLevel { get; set; }

        public virtual PersonGroup Group { get; set; }
    }
}
