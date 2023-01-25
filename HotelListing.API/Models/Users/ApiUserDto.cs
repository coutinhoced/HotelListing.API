﻿using Microsoft.Build.Framework;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace HotelListing.API.Models.Users
{
    public class ApiUserDto : LoginDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
       
    }
}