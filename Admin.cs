using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bsef20m028_hw1_scd
{
    class Admin
    {
        private List<Driver> drivers;

        public Admin()
        {
            drivers = new List<Driver>();
        }

        public void addDriver()
        {
            Console.WriteLine("Enter driver ID:");
            string id = Console.ReadLine();
            Console.WriteLine("Enter driver name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter vehicle type:");
            string vehicleType = Console.ReadLine();
            Console.WriteLine("Enter vehicle model:");
            string vehicleModel = Console.ReadLine();

            drivers.Add(new Driver { ID = id, Name = name, VehicleType = vehicleType, VehicleModel = vehicleModel });
            Console.WriteLine("Driver added successfully.");
        }

        public void updateDriver()
        {
            Console.WriteLine("Enter driver ID to update:");
            string id = Console.ReadLine();

            Driver driver = drivers.Find(d => d.ID == id);
            if (driver == null)
            {
                Console.WriteLine("Driver not found.");
                return;
            }

            Console.WriteLine($"Enter new name (current name: {driver.Name}):");
            string name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
            {
                driver.Name = name;
            }

            Console.WriteLine($"Enter new vehicle type (current type: {driver.VehicleType}):");
            string vehicleType = Console.ReadLine();
            if (!string.IsNullOrEmpty(vehicleType))
            {
                driver.VehicleType = vehicleType;
            }

            Console.WriteLine($"Enter new vehicle model (current model: {driver.VehicleModel}):");
            string vehicleModel = Console.ReadLine();
            if (!string.IsNullOrEmpty(vehicleModel))
            {
                driver.VehicleModel = vehicleModel;
            }

            Console.WriteLine("Driver updated successfully.");
        }

        public void removeDriver()
        {
            Console.WriteLine("Enter driver ID to remove:");
            string id = Console.ReadLine();

            int index = drivers.FindIndex(d => d.ID == id);
            if (index == -1)
            {
                Console.WriteLine("Driver not found.");
                return;
            }

            drivers.RemoveAt(index);
            Console.WriteLine("Driver removed successfully.");
        }

        public void searchDriver()
        {
            Console.WriteLine("Enter search parameter:");
            string parameter = Console.ReadLine();

            List<Driver> searchResults = drivers.FindAll(d => d.ID.Contains(parameter) || d.Name.Contains(parameter) || d.VehicleType.Contains(parameter) || d.VehicleModel.Contains(parameter));

            if (searchResults.Count == 0)
            {
                Console.WriteLine("No drivers found.");
                return;
            }

            Console.WriteLine("Search results:");
            Console.WriteLine("ID\tName\tVehicle Type\tVehicle Model");
            foreach (Driver driver in searchResults)
            {
                Console.WriteLine($"{driver.ID}\t{driver.Name}\t{driver.VehicleType}\t{driver.VehicleModel}");
            }
        }
    }

}
