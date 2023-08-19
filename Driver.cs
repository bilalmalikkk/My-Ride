using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace bsef20m028_hw1_scd
{
    internal class Driver
    {
        //attributes of the class are all private
        private int id;
        private string name;
        private int age;
        private string gender;
        private string address;
        private string phoneNo;
        private Location curr_location;
        private Vehicle vehicle;
        private List<int> rating;
        private bool availability;

        //public constructor of the driver class
        public Driver(string name, int age, string gender, string address, string phoneNo, Location curr_location, Vehicle vehicle)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
            this.phoneNo = phoneNo;
            this.curr_location = curr_location;
            this.vehicle = vehicle;
            this.rating = new List<int>();
            this.availability = true;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int PhoneNo { get; set; }
        public Location currentLocation { get; set; }
        public Vehicle Vehicle { get; set; }

        public bool Availablity { get; set; }

        public void SetRating(int Rating)
        {
            if (rating == null)
            {
                rating = new List<int>();
            }

            if (Rating >= 1 && Rating <= 5)
            {
                rating.Add(Rating);
            }
        }

        //follow are the public functions of driver class
        public void updateAvailability()
        {
                string input;   //declaring a variable input
                do //do while to ensure that rider is availabe for ride or not
                {
                    Console.Write("Are you currently available to take a ride? (yes/no) ");
                    input = Console.ReadLine().ToLower();
                } 
                while (input != "yes" && input != "no");
                    this.availability = input == "yes";
        }

        public double getRating()
        {
  
                if (this.rating.Count == 0) //if rating count is zero return 0
                {
                    return 0;
                }
                double sum = 0;
                foreach (int r in this.rating) //if rating count is not zero then finding average of rating
                {
                    sum += r;
                }
                return sum / this.rating.Count;
        }

        public void updateLocation()
        {
            Console.WriteLine("Please enter your current location: ");
            string lon = Console.ReadLine();
            string lat = Console.ReadLine();

            // Create a new Location object with the entered location information
            Location newLocation = new Location(float.Parse(lat),float.Parse(lon));

            // Update the driver's current location with the new Location object
            curr_location = newLocation;

            Console.WriteLine("Location updated successfully!");
        }


    }




}



    

    
