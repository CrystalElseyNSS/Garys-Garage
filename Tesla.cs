using System;

namespace GarysGarage
{
    public class Tesla : Vehicle
    {
        public int BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            if (BatteryKWh < 10)
            {
                BatteryKWh += 20;
                Console.WriteLine($"Power low, now charging... New power level: {BatteryKWh}!");
            }
            else
            {
                Console.WriteLine($"Battery is juiced! Hit the road!");
            }
        }

        public override void Drive()
        {
            ChargeBattery();
            Console.WriteLine("Zoom Zoom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla just turned {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The Tesla has purred to a stop.");
        }
    }
}