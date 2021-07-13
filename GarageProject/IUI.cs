using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    public interface IUI
    {
        
        public void PrintCountOfVehicles();
        public void PrintAllVehiclesInGarage();
        public void PrintCountOfEachTypeVehicles();
        public void ParkAVehicle(); // Add
        public void TakeOutAVehicle(); //Remove
        public void Search();



    }
}
