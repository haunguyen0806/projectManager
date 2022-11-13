using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class PersonGroup
    {
        public PersonGroup()
        {
            People = new HashSet<Person>();
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int GroupLevel { get; set; }
        public int Odr { get; set; }
        public int? GroupParentId { get; set; }
        public string UserId { get; set; }
        public int? Status { get; set; }
        public string GroupType { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}
