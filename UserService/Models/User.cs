using System;
using System.Collections.Generic;

namespace UserService.Models
{
    public partial class User
    {
        public int UseId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? IsActive { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string MobNo { get; set; }
        public string Pin { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string MiddleName { get; set; }
        public string Pwd { get; set; }
        public string UserName { get; set; }
    }
}
