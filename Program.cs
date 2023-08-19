using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bsef20m028_hw1_scd
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("WELCOME TO MYRIDE");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("1. Book a Ride");
                Console.WriteLine("2. Enter as Driver");
                Console.WriteLine("3. Enter as Admin");
                Console.Write("Press 1 to 3 to select an option: ");
                string input = Console.ReadLine();
                Console.Clear();
                switch (input)
                {
                    case "1":
                        bookARide();
                        break;
                    case "2":
                        //EnterAsDriver();
                        break;
                    case "3":
                        //EnterAsAdmin();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
            void bookARide()
            {
                
                Console.WriteLine("Book a Ride\n");

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Phone no: ");
                string phone = Console.ReadLine();

                Console.Write("Enter Start Location (x,y): ");
                string startLocation = Console.ReadLine();

                Console.Write("Enter End Location (x,y): ");
                string endLocation = Console.ReadLine();

                Console.Write("Enter Ride Type: ");
                string rideType = Console.ReadLine();

                Console.WriteLine("\n-------------------- THANK YOU ------------------");
                Console.WriteLine($"Price for this ride is: 200");
                Console.Write("Enter ‘Y’ if you want to Book the ride, enter ‘N’ if you want to cancel operation: ");
                string confirm = Console.ReadLine();

                if (confirm.ToLower() == "y")
                {
                    Console.WriteLine("\nHappy Travel…!");
                    Console.Write("Give rating out of 5: ");
                    int rating = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("                  Welcome To MYRIDE                       ");
            Console.WriteLine("--------------------------------------------------------------");
            bool mainCheck = true;
            Ride ride = new Ride();
            Admin admin = new Admin();
            Driver driver = new Driver();

            while (mainCheck)
            {
                Console.WriteLine("Enter as a");
                Console.WriteLine("1. Rider");
                Console.WriteLine("2. Driver");
                Console.WriteLine("3. Admin");

                Console.WriteLine("Enter your choice (1-3):");
                Console.WriteLine("Enter -1 to exit:");

                int choice = int.Parse(Console.ReadLine()!);
                if (choice == -1)
                {
                    mainCheck = false;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Book A Ride");
                        Console.WriteLine("Enter name");
                        Console.ReadLine();
                        Console.WriteLine("Enter phone Number");
                        Console.ReadLine();
                        Console.WriteLine("Enter Start Location(Latitude)");
                        float latitude = float.Parse(Console.ReadLine()!);
                        Console.WriteLine("Enter Start Location(Longitude)");
                        float longitude = float.Parse(Console.ReadLine()!);
                        Location location1 = new Location(latitude, longitude);
                        ride.StartLocation = location1;
                        Console.WriteLine("Enter End Location(Latitude)");
                        float latitude1 = float.Parse(Console.ReadLine()!);
                        Console.WriteLine("Enter End Location(Longitude)");
                        float longitude1 = float.Parse(Console.ReadLine()!);
                        Location location2 = new Location(latitude, longitude);
                        ride.EndLocation = location2;
                        Console.WriteLine("Enter Ride Type");
                        string ridetype = Console.ReadLine()!;

                        Console.WriteLine("______________________________________________");
                        Console.WriteLine("              THANK YOU                      ");
                        Console.WriteLine("Price for this ride is " + ride.CalculatePrice(ridetype));
                        Console.WriteLine("Enter Y if you want to Book the ride, enter N if you want to cancel operation: ");
                        string ans = Console.ReadLine()!;
                        if (ans == "Y" || ans == "y")
                        {
                            ride.AssignDriver(admin.drivers);
                            Console.WriteLine("Happy Travel");
                        }
                        else
                        {
                            Console.WriteLine("Thank you for considering us");
                        }
                        Console.WriteLine("Give rating out of 5: ");

                        ride.GiveRating(driver: ride.Driver!, int.Parse(Console.ReadLine()!));
                        break;
                    case 2:

                        bool status = admin.search();
                        if (status == true)
                        {
                            Console.WriteLine("HeLLo " + driver.name);
                            Console.WriteLine("Enter your current location: ");
                            Console.WriteLine("Enter current Location(Latitude)");
                            float latitude3 = float.Parse(Console.ReadLine()!);
                            Console.WriteLine("Enter current Location(Longitude)");
                            float longitude3 = float.Parse(Console.ReadLine()!);
                            Location location3 = new Location(latitude3, longitude3);
                            driver.currLocation = location3;

                            Console.WriteLine("What do you want to do");
                            Console.WriteLine("1. Change Availability");
                            Console.WriteLine("2. Change Location");
                            Console.WriteLine("3. Exit");

                            Console.WriteLine("Enter your choice (1-3):");


                            int choice3 = int.Parse(Console.ReadLine()!);




                            switch (choice3)
                            {
                                case 1:
                                    driver.updateAvailability();

                                    break;
                                case 2:
                                    driver.updateLocation();

                                    break;
                                case 3:
                                    break;



                                default:
                                    Console.WriteLine("Invalid choice. ");

                                    break;
                            }



                        }
                        else
                        {
                            Console.WriteLine("You are not registered");
                            break;
                        }

                        break;
                    case 3:

                        Console.WriteLine("What do you want to do");
                        Console.WriteLine("1. Add Driver");
                        Console.WriteLine("2. Update Drive Information");
                        Console.WriteLine("3. Delete Driver");
                        Console.WriteLine("4. Search Driver");
                        Console.WriteLine("Enter your choice (1-4):");


                        int choice2 = int.Parse(Console.ReadLine()!);




                        switch (choice2)
                        {
                            case 1:
                                admin.addDriver();

                                break;
                            case 2:
                                admin.updateDriver();

                                break;
                            case 3:
                                admin.deleteDriver();

                                break;
                            case 4:
                                admin.searchDriver();
                                break;

                            default:
                                Console.WriteLine("Invalid choice. ");

                                break;
                        }

                        break;


                    default:
                        Console.WriteLine("Invalid choice. ");
                        break;
                }



            }







        }
    }
}
        

        




                









