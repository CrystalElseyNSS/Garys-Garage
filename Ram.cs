using System;

namespace GarysGarage
{
    public class Ram : Vehicle
    {
        public int FuelLevel { get; set; }

        public void RefuelTank()
        {
            if (FuelLevel < 5)
            {
                FuelLevel += 25;
                Console.WriteLine($"One moment, gassing up! New fuel level: {FuelLevel} gallons.");
            }
            else{
                Console.WriteLine("Tank's full! Enjoy your ride!");
            }
        }       
        public override void Drive()
        {
            RefuelTank();
            Console.WriteLine("Rummummmummmummm!");
        }
    }
}