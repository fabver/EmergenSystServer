using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class GeoLocation
    {
        public string cedula { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }

        public GeoLocation(string lat, string lng)
        {
            this.lat = lat; 
            this.lng = lng;
        }

        public string toString()
        {
            return "lat: " + this.lat + "; lng: " + this.lng;
        }

    }
}
