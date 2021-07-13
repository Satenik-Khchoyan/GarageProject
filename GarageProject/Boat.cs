using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    public class Boat : Vehicle
    {
        private int numberOfEngines;

        public int NumberOfEngines
        {
            get { return numberOfEngines; }
            set { numberOfEngines = value; }
        }
        public Boat(string regNo, string type, string color, int countOfWheels, int numberOfEngines) : base(regNo, type, color, countOfWheels)
        {
            NumberOfEngines = numberOfEngines;
        }
    }
}
