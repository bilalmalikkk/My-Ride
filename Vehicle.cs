using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bsef20m028_hw1_scd
{
    internal class Vehicle
    {
        // declaring three private attributes of Vehicle class
        private string type;
        private string model;
        private string license_plate;

        public Vehicle()
        {

        }
        public Vehicle(string type, string model, string license_plate)
        {
            this.type = type;
            this.model = model;
            this.license_plate = license_plate;
        }

        public string Type{ get; set; }
        public string Model { get; set; }
        public string License_plate { get; set;}
    }

    
}
