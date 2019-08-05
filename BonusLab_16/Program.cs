using System;

namespace BonusLab_16
{
    class Program
    {
        static void Main(string[] args)
        {
            CarApp ca = new CarApp();
            Car c = new Car();

            Console.WriteLine("Welcome to the Grand Circus admin console!");
            ca.GetCarInfo();
            ca.PrintCars();
        }
    }
}
