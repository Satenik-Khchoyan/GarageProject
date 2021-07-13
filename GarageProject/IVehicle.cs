using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    public interface IVehicle
    {
        public string RegNo { get; set; } 
        public string Color { get; set; }
        public int CountOfWheels { get; set; }
        public string VehicleType { get; set; }
    }
}
