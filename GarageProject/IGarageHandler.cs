using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    public interface IGarageHandler<T>
    {
        public int CountOfVehicles();
        public void AddVehicle(Vehicle newVehicle);
        public void RemoveVehicle(string regNo);
        public List<Dictionary<string, string>> ListOutAllVehiclesInGarage();
        public List<Dictionary<string, int>> CountOfEachTypeVehicles();
        public void Search(string regNr = "", string color = "", string vtype = "", int countOfWheels = 0);
        public bool IsRegNoExist(string regNo);

    }
}
