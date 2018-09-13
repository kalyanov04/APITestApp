using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestApp.User
{
    public class Address
    {
        string street;
        string suite;
        string city;
        int zipcode;
        Geo geo;
        public Address(string street, string suite, string city, int zipcode, Geo geo)
        {
            this.Street = street;
            this.Suite = suite;
            this.City = city;
            this.Zipcode = zipcode;
            this.Geo = geo;
        }

        public string Street { get => street; set => street = value; }
        public string Suite { get => suite; set => suite = value; }
        public string City { get => city; set => city = value; }
        public int Zipcode { get => zipcode; set => zipcode = value; }
        public Geo Geo { get => geo; set => geo = value; }
    }
}
