using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    public class Motorcycle: Vehicle
    {
        private double cylinderVolume;

        public double CylinderVolume
        {
            get { return cylinderVolume; }
            set { cylinderVolume = value; }
        }
        public Motorcycle(string regNo, string type, string color, int countOfWheels, double cylinderVolume) : base(regNo, type, color, countOfWheels)
        {
            CylinderVolume = cylinderVolume;
        }
    }
}
