using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GarageProject
{
    public class Garage<T> : IGarage<T>, IEnumerable<T> where T : IVehicle
    {

        private IVehicle[] vehicles;

        public int Capacity { get; set; }
        public Garage(int capacity)
        {
            Capacity = capacity;
            vehicles = new Vehicle[capacity];

        }

        public void AddVehicle(Vehicle newVehicle)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = newVehicle;
                    break;
                }
            }

        }

        public bool IsRegNoExist(string regNo)
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle.RegNo.Equals(regNo))
                    return true;
            }
            return false;
        }
        public void RemoveVehicle(string regNo)
        {
            //foreach (var vehicle in vehicles)
            //{
            //    if (vehicle.RegNo.Equals(regNo))
            //    {

            //    }
            //}
            
            vehicles = vehicles.Where(v => !(v.RegNo.Equals(regNo))).ToArray(); // NullReference exception
        }

        public List<Dictionary<string, string>> ListOutAllVehiclesInGarage()
        {
            List<Dictionary<string, string>> vehicleList = new List<Dictionary<string, string>>();
            string vehicleType;
            string regNo;
            foreach (var vehicle in vehicles)
            {
                if (vehicle != null)
                {
                    vehicleType = vehicle.VehicleType;
                    regNo = vehicle.RegNo;
                    Dictionary<string, string> vehicleDict = new Dictionary<string, string>();
                    vehicleDict.Add(regNo, vehicleType);
                    vehicleList.Add(new Dictionary<string, string>(vehicleDict));
                }
            }
            return vehicleList;
        }
        public List<Dictionary<string, int>> CountOfEachTypeVehicles()
        {
            var list = GetVehicleTypes();
            List<Dictionary<string, int>> typeList = new List<Dictionary<string, int>>();
        
            var query = list.GroupBy(x => x)
              .Where(g => g.Count() >= 1)
              .ToDictionary(x => x.Key, y => y.Count());

            typeList.Add(query);
            return typeList;
        }

        public List<string> GetVehicleTypes()
        {
            List<string> vehicleTypeList = new List<string>();
            foreach (var item in vehicles)
            {
                if (item != null)
                { vehicleTypeList.Add(item.VehicleType); }
            }
            return vehicleTypeList;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle != null)
                {
                    yield return (T)vehicle;
                }
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
