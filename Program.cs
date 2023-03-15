using System;

namespace CarSelector
{
    public class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            Console.WriteLine("Welcome to my simple Car creation C# console app");

            int choice = Action();

                while (choice != 1)
                {
                try
                {
                Statment_Start:
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("See ya!");
                            break;
                        case 2:
                            Console.WriteLine("You have Chosen to create a car!");
                            string carColor = "";
                            string carMake = "";
                            string carModel = "";
                            // Read input
                            Console.WriteLine("Please enter your color: ");
                            carColor = Console.ReadLine();
                            Console.WriteLine("Please enter your make: ");
                            carMake = Console.ReadLine();
                            Console.WriteLine("Please enter your model: ");
                            carModel = Console.ReadLine();
                            Console.WriteLine("\r\n");

                            // Create the Car
                            CarCreate newCar = new CarCreate(carColor, carMake, carModel);
                            // Add to the List
                            garage.CarList.Add(newCar);
                            // Show the garage
                            showCars(garage);
                            choice = Action();
                            break;

                        case 3:
                            foreach (var item in garage.CarList)
                            {
                                Console.WriteLine($"Color: {item.Color}");
                                Console.WriteLine($"Make: {item.Name}");
                                Console.WriteLine($"Model: {item.Model}");
                                Console.WriteLine("\r\n");
                            }
                            choice = Action();
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }

                }
                catch (Exception)
                {

                    throw;
                }
                }
            }
        

        public static void showCars(Garage garage)
        {
            foreach (CarCreate item in garage.CarList)
            {
                Console.WriteLine("Car Color: " + item.Color);
                Console.WriteLine("Car Make: " + item.Name);
                Console.WriteLine("Car Model: " + item.Model);
                Console.WriteLine("\r\n");

            }
        }

        public static int Action()
        {
            int action = 0;
            Number_Needed:
            Console.WriteLine("Please select from the following: \n Enter 1 to quit.\n Enter 2 to add a car.\n Enter 3 to view our cars ");
            try
            {
                
                action = int.Parse(Console.ReadLine());
                if (action == 1 || action == 2 || action == 3)
                {
                    return action;
                }
                else
                {
                    Console.WriteLine("Sorry, that is not a valid option!");
                    goto Number_Needed;
                }
            }
            catch
            {
                Console.WriteLine($"Unfortunatly we need a number!");
                goto Number_Needed;
            }
            
        }
    }
}
