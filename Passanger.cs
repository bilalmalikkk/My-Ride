using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace bsef20m028_hw1_scd
{
    internal class Passanger
    {
        // delaring two private attributes of Passanger class
        private string name;
        private string phoneNo;

        public Passanger(string name,string phoneNo)
        {
            this.name = name;
            this.phoneNo = phoneNo; 
        }
        public string Name { get; set; }
        public string PhoneNo { get; set; }

        public void bookRide()//function to book ride after getting starting and ending location
        {
            Console.WriteLine("Enter starting location:");
            string startingLocation = Console.ReadLine();
            Console.WriteLine("Enter ending location:");
            string endingLocation = Console.ReadLine();
            Console.WriteLine("Enter Name of Passanger:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter PhoneNo of Passanger:");
            PhoneNo = Console.ReadLine();
            Console.WriteLine("Congratulations!your ride confirmed successfully!");
        }
        public void giveRating()//function that gives rating to the rider within the limit of 1-5
        {
            Console.WriteLine("Please rate your ride from 1 to 5:");
            int rating = Convert.ToInt32(Console.ReadLine());
            while (rating < 1 || rating > 5)
            {
                Console.WriteLine("Invalid rating. Please rate your ride from 1 to 5:");
                rating = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
