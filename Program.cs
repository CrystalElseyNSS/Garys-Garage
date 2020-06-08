using System;

namespace GarysGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle MyVehicle = new Vehicle();
            MyVehicle.MainColor = "Neon Pink";
            MyVehicle.MaximumOccupancy = "6";

            Tesla MyTesla = new Tesla();
            MyTesla.MainColor = "Fire Engine Red";
            MyTesla.MaximumOccupancy = "2";
            MyTesla.BatteryKWh = 8;

            Ram MyRam = new Ram();
            MyRam.MainColor = "Canary Yellow";
            MyRam.MaximumOccupancy = "4";
            MyRam.FuelLevel = 3;


            Console.WriteLine("And they're off!");
            Console.WriteLine("---------------------------");
            MyVehicle.Drive();
            MyVehicle.Turn("right");
            MyVehicle.Stop();
            Console.WriteLine("---------------------------");    
            MyTesla.Drive();
            MyTesla.Turn("left");
            MyTesla.Stop();
            Console.WriteLine("---------------------------");
            MyRam.Drive();
            MyRam.Turn("right, then left");
            MyRam.Stop();
        }
    }
}