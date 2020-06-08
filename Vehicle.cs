using System;

namespace GarysGarage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} vehicle just turned {direction}.");
        }

        public virtual void Stop()
        {
            Console.WriteLine($"The vehicle has stopped at the red light.");
        }
    }   
}