using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    public class Airplane: Vehicle
    {
        private int numberOfSeats;

        public int NumberOfSeats
        {
            get { return numberOfSeats; }
            set { numberOfSeats = value; }
        }
        public Airplane(string regNo, string type, string color, int countOfWheels, int numberOfSeats): base(regNo, type, color, countOfWheels)
        {
            NumberOfSeats = numberOfSeats;
        }

    }
}
