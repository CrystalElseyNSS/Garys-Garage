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
                Console.WriteLine($"Power is low, charging battery... New power level: {BatteryKWh}");
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
    }
}