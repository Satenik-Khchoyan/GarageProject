using System;
using System.Collections.Generic;

namespace GarageProject
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the capacity of garage.");
            IUI user = new UI();
            
            while (true)
            {

                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 5, 6, 0) of your choice"
                        + "\n1. Print a count of parked vehicles in garage"
                        + "\n2. Park your vehicle"
                        + "\n3. List out all vehicles"
                        + "\n4. Count of each type of vehicle in garage"
                        + "\n5. Search with different criteria"
                        + "\n6. Take out your vehicle"
                        + "\n0. Exit the application");

                char input = ' ';
                try
                {
                    input = Console.ReadLine()[0];
                
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
       


                switch (input)
                {
                    case '1':
                        user.PrintCountOfVehicles();
                        break;
                    case '2':
                        user.ParkAVehicle();
                        break;
                    case '3':
                        user.PrintAllVehiclesInGarage();
                        break;
                    case '4':
                        user.PrintCountOfEachTypeVehicles();
                        break;
                    case '5':
                        user.Search();
                        break;
                    case '6':
                        user.TakeOutAVehicle();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4, 5, 6)");
                        break;
                }
            }
        }
      
    }
}
