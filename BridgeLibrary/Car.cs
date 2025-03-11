using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLibrary
{
    public class Car
    {
        public string LicensePlate { get; private set; }
        public DateTime Date { get; private set; }

        public double Price()
        {
            return 230;
        }

        public string VehicleType()
        {
            return "Car";
        }
    }
}
