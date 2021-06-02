using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    static class VehicleFactory
    {
        public static IVehicle GetVehicle(string numWheels)
        {
            switch (numWheels)
            {
                case "4":
                    return new Car();
                case "6":
                    return new DualyTruck();
                case "2":
                    return new Motorcycle();

                default:
                    return new Car();
            }
        }
    }
}
