using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    public class UI : IUI
    {
        public IGarageHandler<Vehicle> Handler { get; set; }



        int capacity = AskForInt();
        public UI()
        {
            Handler = new GarageHandler<Vehicle>(capacity);
        }


        public void ParkAVehicle()
        {
            bool isParked = false;
            List<string> regNumbers = new List<string>();
            Console.WriteLine("Write your register number. This number is unique.");
            string regNo = Console.ReadLine();
            if (regNumbers != null)
            {
                foreach (var item in regNumbers)
                {
                    if (regNo.Equals(item.ToLower()))
                    {
                        Console.WriteLine("A vehicle with same register number already has parked. Register number must be unique.");
                    }
                    else
                    {
                        regNumbers.Add(regNo);

                    }
                }
            }
            Console.WriteLine("Which color is your vehicle?");
            string color = Console.ReadLine();
            Console.WriteLine("How many wheels have your vehicle?");
            int countOfWheels = AskForInt();
            Console.WriteLine("Which type of vehicle do you want to park?");
            string type = Console.ReadLine();
            if (type.Equals("Airplane") || type.Equals("airplane"))
            {
                Console.WriteLine("Write number of seat.");
                int numberOfSeats = AskForInt();
                var vehicle = new Airplane(regNo, type, color, countOfWheels, numberOfSeats);
                Handler.AddVehicle(vehicle);
                isParked = true;
            }
            else
                if (type.Equals("Boat") || type.Equals("boat"))
            {
                Console.WriteLine("Write number of engines.");
                int numberOfEngines = AskForInt();
                var vehicle = new Boat(regNo, type, color, countOfWheels, numberOfEngines);
                Handler.AddVehicle(vehicle);
                isParked = true;
            }
            else
                if (type.Equals("Bus") || type.Equals("bus"))
            {
                Console.WriteLine("Write length of bus.");
                double length = AskForDouble();
                var vehicle = new Bus(regNo, type, color, countOfWheels, length);
                Handler.AddVehicle(vehicle);
                isParked = true;
            }
            else
                 if (type.Equals("Car") || type.Equals("car"))
            {
                Console.WriteLine("Which type of fuel do your car use?.");
                string fuelType = Console.ReadLine();
                var vehicle = new Car(regNo, type, color, countOfWheels, fuelType);
                Handler.AddVehicle(vehicle);
                isParked = true;
            }
            else
                 if (type.Equals("Motorcycle") || type.Equals("motorcycle"))
            {
                Console.WriteLine("Write the volume of cylinder.");
                double cylinderVolume = AskForDouble();
                var vehicle = new Motorcycle(regNo, type, color, countOfWheels, cylinderVolume);
                Handler.AddVehicle(vehicle);
                isParked = true;
            }
            else
            {
                Console.WriteLine("We are currently accepting just airplanes, boats, busses, cars and motorcycles.");
            }

            if (isParked == true)
            {
                Console.WriteLine($"Your {type.ToLower()} is successfully parked!");
            }

        }

        private static int AskForInt()
        {
            bool isInt = false;
            int answer;
            do
            {
                string userCount = Console.ReadLine();
                isInt = int.TryParse(userCount, out answer) && answer > 0;

            } while (!isInt);

            return answer;
        }

        private static double AskForDouble()
        {
            bool isDouble = false;
            double answer;
            do
            {
                string userCount = Console.ReadLine();
                isDouble = double.TryParse(userCount, out answer) && answer > 0;

            } while (!isDouble);

            return answer;
        }

        public void PrintCountOfVehicles()
        {
            Console.WriteLine($"There are {Handler.CountOfVehicles()} vehicles in garage");
        }

        public void PrintAllVehiclesInGarage()
        {
            if (Handler.ListOutAllVehiclesInGarage() != null)
            {
                Console.WriteLine("Here are all vehicles parked in garage.");
                foreach (var item in Handler.ListOutAllVehiclesInGarage())
                {
                    foreach (KeyValuePair<string, string> dict in item)
                    {
                        Console.WriteLine($"RegNo: {dict.Key}, Vehicle type: {dict.Value}");
                    }
                }
            }
            else
            {
                Console.WriteLine("There are no vehicles in garage.");
            }

        }


        public void PrintCountOfEachTypeVehicles()
        {
            if (Handler.CountOfEachTypeVehicles() != null)
            {
                foreach (var item in Handler.CountOfEachTypeVehicles())
                {
                    foreach (KeyValuePair<string, int> dict in item)
                    {
                        Console.WriteLine($"Vehicle type: {dict.Key} Count: {dict.Value}");
                    }
                }
            }
            else
            {
                Console.WriteLine("There are no vehicles in garage.");
            }
        }



        public void TakeOutAVehicle()
        {
            Console.WriteLine("Welcome to take your vehicle out of garage. Please enter the register number of your vehicle.");
            string regNo = Console.ReadLine();
            if (Handler.IsRegNoExist(regNo))
            {
                Handler.RemoveVehicle(regNo);
                Console.WriteLine("Your vehicle has now taken out from garage! Welcome back!");
            }
            else
            {
                Console.WriteLine("There is no vehicle with such register number parked in garage.");
            }
        }

        public void Search()
        {
            Console.WriteLine("Choose which criteria do you want to search with. You can choose more than one criteria. "
                              + "\n1 Register number"
                              + "\n2 Color"
                              + "\n3 Vehicle type"
                              + "\n4 Count of wheels"
                              + "\n5 Print the result");
            string regNo = "";
            string color = "";
            string vehicleType = "";
            int countOfWheels = 0;
            bool isSearchDone = false;

            while (isSearchDone == false)
            {
                int chooseNumber = AskForInt();
                switch (chooseNumber)
                {
                    case 1:
                        regNo = Console.ReadLine();
                        break;
                    case 2:
                        color = Console.ReadLine();
                        break;
                    case 3:
                        vehicleType = Console.ReadLine();
                        break;
                    case 4:
                        countOfWheels = AskForInt();
                        break;
                    case 5:
                        Handler.Search(regNo, color, vehicleType, countOfWheels);
                        isSearchDone = true;
                        break;
                    default:
                        Console.WriteLine("Enter numbers 1, 2, 3, 4, 5");
                        break;

                }

            }



        }
    }
}
