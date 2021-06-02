using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class DualyTruck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building a new Dualie Truck");
        }
    }
}
