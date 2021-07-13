using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    interface IGarage<T> : IEnumerable<T>
    {
        public void AddVehicle(Vehicle newVehicle);
        public void RemoveVehicle(string regNo);
        public List<Dictionary<string, string>> ListOutAllVehiclesInGarage();
        public List<string> GetVehicleTypes();
        public List<Dictionary<string, int>> CountOfEachTypeVehicles();
        public bool IsRegNoExist(string regNo);


    }
}
