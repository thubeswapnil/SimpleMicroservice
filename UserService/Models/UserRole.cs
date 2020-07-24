using System;
using System.Collections.Generic;

namespace UserService.Models
{
    public partial class UserRole
    {
        public int UserRoleId { get; set; }
        public string Role { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedDate { get; set; }
    }
}
