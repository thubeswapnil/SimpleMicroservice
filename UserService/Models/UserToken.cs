using System;
using System.Collections.Generic;

namespace UserService.Models
{
    public partial class UserToken
    {
        public int UserTokenId { get; set; }
        public int UserId { get; set; }
        public string UserToken1 { get; set; }
        public int? DeviceTypeId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
