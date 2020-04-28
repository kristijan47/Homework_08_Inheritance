using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_08_Inheritance.Models
{
    public class FuelCar:Car
    {
        public int FuelCapacity = 60;
        public int CurrentFuel;

        public int Refuel(int fuel)
        {
            if (fuel > FuelCapacity)
            {
                Console.WriteLine($"Can't refuel more than {FuelCapacity} litres");
            }
            else
            {
                Console.WriteLine($"Tank has been fueled with {fuel} litres.");
            }

            return fuel;
        }

    }
}
