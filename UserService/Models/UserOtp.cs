using System;
using System.Collections.Generic;

namespace UserService.Models
{
    public partial class UserOtp
    {
        public int Otpid { get; set; }
        public string Otp { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
