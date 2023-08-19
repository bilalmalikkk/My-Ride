using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bsef20m028_hw1_scd
{
    internal class Ride
    {
        //declaring private attributes of the Ride class
        private Location start_location;
        private Location end_location;
        private int price;
        private Driver driver;
        private Passanger passanger;

        public Ride(Location start_location, Location end_location, int price, Driver driver, Passanger passanger)
        {
            this.start_location = start_location;
            this.end_location = end_location;
            this.price = price;
            this.driver = driver;
            this.passanger = passanger;
        }
        public Location StartLoc { get; set; }
        public Location EndLoc { get; set; }
        public int Price { get; set; }
        public Driver Drivr { get; set; }
        public Passanger Passangr { get; set; }
        public void assignPassenger()
        {
            Console.WriteLine("Please enter the passenger's name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter the passenger's destination: ");
            string phoneno = Console.ReadLine();

            // Create a new Passenger object with the entered information
            Passanger passenger = new Passanger(name, phoneno);

            Console.WriteLine("Passenger assigned successfully!");
        }


        public void assignDriver(List<Driver> drivers)
        {
            double shortestDistance = double.MaxValue;
            Driver closestDriver = null;
            foreach (Driver driver in drivers)
            {
                if (driver.Availablity)
                {
                    double distance = calculateDistance(start_location, end_location);
                    if (distance < shortestDistance)
                    {
                        shortestDistance = distance;
                        closestDriver = driver;
                    }
                }
            }
            this.driver = closestDriver;
            this.driver.Availablity = false;
        }
        public void getLocations(Location start_location, Location end_location)
        {
            this.start_location = start_location;
            this.end_location = end_location;
        }

        public void calculatePrice()
        {
            double distance = calculateDistance(start_location, end_location);
            double fuel_price = 2.0; // hardcoded petrol price per liter
            double commission = 0.0;
            Vehicle veh = new Vehicle();
            if (veh.Type == "Bike")
            {
                double fuel_average = 50.0; // fuel average in km/liter for Bike
                commission = 0.05;
                price = (int)Math.Round((distance * fuel_price / fuel_average) + (price * commission));
            }
            
            else if (veh.Type == "Rickshaw")
            {
                double fuel_average = 35.0; // fuel average in km/liter for Rickshaw
                commission = 0.1;
                price = (int)Math.Round((distance * fuel_price / fuel_average) + (price * commission));
            }
            else if (veh.Type == "Car")
            {
                double fuel_average = 15.0; // fuel average in km/liter for Car
                commission = 0.2;
                price = (int)Math.Round((distance * fuel_price / fuel_average) + (price * commission));
            }
            else
            {
                Console.WriteLine("Invalid vehicle type.");
            }
        }

        private double calculateDistance(Location start_location, Location end_location)
        {
            double x = start_location.Latitude - end_location.Latitude;
            double y = start_location.Longitude - end_location.Longitude;
            return Math.Sqrt(x * x + y * y);
        }







    }
}
