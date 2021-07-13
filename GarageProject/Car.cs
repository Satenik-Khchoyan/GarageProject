using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    public class Car : Vehicle 
    {
        private string fuelType;

        public string FuelType
        {
            get { return fuelType; }
            set { fuelType = value; }
        }
        public Car(string regNo, string type, string color, int countOfWheels, string fuelType) : base(regNo, type, color, countOfWheels)
        {
            FuelType = fuelType;
        }
    }
}
