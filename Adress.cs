using System;
using System.Collections.Generic;
using System.Text;

namespace AdressBook
{
    public class Adress
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }

        public Adress(string City, string Country, string Street, string StreetNumber)
        {
            this.City = City;
            this.Country = Country;
            this.Street = Street;
            this.StreetNumber = StreetNumber;
        }
    }
}
