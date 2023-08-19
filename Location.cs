using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bsef20m028_hw1_scd
{
    internal class Location
    {
        //declaring two private attributes of Location class
        private float latitude;
        private float longitude;

        public Location(float latitude,float longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        

    }
}
