using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Manager.Models
{
    public partial class SysUser
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserPos { get; set; }
        public string MobileNumber { get; set; }
        public string UserPwd { get; set; }
        public bool Status { get; set; }
    }
}
