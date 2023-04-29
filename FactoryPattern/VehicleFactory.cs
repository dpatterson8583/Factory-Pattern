using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int Tires)
        {
            if(Tires==2)
            {

                return new Motorcycle();
            }
            else
            {

                return new Car();
            }

        }
    }
}
