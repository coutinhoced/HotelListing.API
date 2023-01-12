﻿using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Data
{
    //One to One
    //One to many
    //Many to Many - DB Relations
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }

        [ForeignKey(nameof(CountryId))]
        public int CountryId { get; set; }  

        public Country Country { get; set; }

    }
}
