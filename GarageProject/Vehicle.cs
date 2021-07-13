using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    public abstract class Vehicle : IVehicle
    {
        
        public string RegNo { get; set; } 
        public string Color { get; set; }
        public int CountOfWheels { get; set; }
        public string VehicleType { get; set; }
        public Vehicle()
        {

        }
        public Vehicle(string regNo, string vehicleType, string color, int countOfWheels)
        {
            RegNo = regNo;
            VehicleType = vehicleType;
            Color = color;
            CountOfWheels = countOfWheels;
        }
    }
}
