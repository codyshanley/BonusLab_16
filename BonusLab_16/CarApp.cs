using System;
using System.Collections.Generic;
namespace BonusLab_16
{
    public class CarApp
    {
        List<Car> cars = new List<Car>();

        public CarApp()
        {
        }

        public void GetCarInfo()
        {
            Console.Write("How many cars are you entering?: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {

                Console.Write("Enter Car #" + (i + 1) + " Make:");
                string make = Console.ReadLine();

                Console.Write("Enter Car #" + (i + 1) + " Model:");
                string model = Console.ReadLine();

                Console.Write("Enter Car #" + (i + 1) + " Year:");
                string year = Console.ReadLine();

                Console.Write("Enter Car #" + (i + 1) + " Price:");
                string price = Console.ReadLine();

                cars.Add(new Car(int.Parse(year), make, model, int.Parse(price)));
            }
        }

        public void PrintCars()
        {
            Console.WriteLine("Current Inventory:");

            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine(cars[i].ToString());
            }
        }


    }
}
