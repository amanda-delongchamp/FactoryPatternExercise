using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels do you want?  Enter number 2, 4 or 6");

            string numWheels = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(numWheels);
            vehicle.Drive();
            Console.ReadLine();
        }
    }
}
