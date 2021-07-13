using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    public class GarageHandler<T> : IGarageHandler<T> where T : IVehicle
    {
    
        public Garage<T> Garage { get; set; }
        public int Capacity { get; set; }

        public GarageHandler(int capacity)
        {
            Capacity = capacity;
            Garage = new Garage<T>(capacity);
        }
       
        public int CountOfVehicles()
        {
            var count = 0;

            foreach (var vehicle in Garage)
            {
                count++;
            }
            return count;
        }
        public List<Dictionary<string,string>> ListOutAllVehiclesInGarage()
        {
           return  Garage.ListOutAllVehiclesInGarage();
        }
        
        public void AddVehicle(Vehicle newVehicle)
        {

            Garage.AddVehicle(newVehicle);
        }

        public bool IsRegNoExist(string regNo)
        {
            return Garage.IsRegNoExist(regNo);
        }
        public void RemoveVehicle(string regNo)
        {
            Garage.RemoveVehicle(regNo);
        }

        public List<Dictionary<string, int>> CountOfEachTypeVehicles()
        {
            return Garage.CountOfEachTypeVehicles();
        }

        public void Search(string regNr = "", string color = "", string vtype = "", int countOfWheels = 0)
        {

            var searchResult = Garage.Select(v => v);


            if (regNr != "")
            {
                searchResult = searchResult.Where(v => v.RegNo.ToLower() == regNr.ToLower());
            }
            if (color != "")
            {
                searchResult = searchResult.Where(v => v.Color.ToLower() == color.ToLower());
            }
            if (countOfWheels != 0)
            {
                searchResult = searchResult.Where(v => v.CountOfWheels == countOfWheels);
            }
            if (vtype != "")
            {
                searchResult = searchResult.Where(v => v.GetType().Name.ToLower() == vtype.ToLower());
            }

            foreach (var vehicle in searchResult)
            {
                Console.WriteLine($"{vehicle.RegNo} {vehicle.VehicleType}");
            }
            
        }
    }
}
