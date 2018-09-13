using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestApp.User
{
    public class Geo
    {
        double lat;
        double lng;

        public Geo(double lat, double lng)
        {
            this.lat = lat;
            this.lng = lng;
        }
    }
}
