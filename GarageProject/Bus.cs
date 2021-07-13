using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    public class Bus : Vehicle 
    {
        private double length;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public Bus(string regNo, string type, string color, int countOfWheels, double length) : base(regNo, type, color, countOfWheels)
        {
            Length = length;
        }
    }
}
