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
            this.street = street;
            this.suite = suite;
            this.city = city;
            this.zipcode = zipcode;
            this.geo = geo;
        }
    }
}
