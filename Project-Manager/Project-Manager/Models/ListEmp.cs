using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class ListEmp
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string AlterEmail { get; set; }
        public string HomePhone { get; set; }
        public string BusinessPhone { get; set; }
        public string MobilePhone { get; set; }
        public string UserPosition { get; set; }
        public string DeptId { get; set; }
        public string OrgId { get; set; }
        public bool? Sex { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string PermanentPlace { get; set; }
        public string Province { get; set; }
        public string TemporaryAddress { get; set; }
        public string EducationLevel { get; set; }
        public string Occupation { get; set; }
        public bool? MaritalStatus { get; set; }
        public string Idcard { get; set; }
        public DateTime? IdcardDate { get; set; }
        public string IdcardPlaceOfIssue { get; set; }
        public string Job { get; set; }
        public string Notes { get; set; }
        public bool? Status { get; set; }
    }
}
