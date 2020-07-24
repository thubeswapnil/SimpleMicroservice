using System;
using System.Collections.Generic;

namespace UserService.Models
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public int? UserId { get; set; }
        public string HouseNumber { get; set; }
        public string ApartmentName { get; set; }
        public string Address1 { get; set; }
        public string LandmarkName { get; set; }
        public string AreaDetails { get; set; }
        public string PinCode { get; set; }
        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public string MobNo { get; set; }
        public string Email { get; set; }
    }
}
