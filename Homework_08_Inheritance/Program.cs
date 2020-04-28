using System;
using Homework_08_Inheritance.Models;
using Homework_08_Inheritance.Enums;
using CarServices;

namespace Homework_08_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCar = new Car()
            {
                CarBrand = "Audi",
                CarModel = "A6",
                NumberOfDoors = 4,
                TopSpeed = 260,
                Consumption = Consumption.Economic,
                EngineType = EngineType.Diesel,
                CarId = CarIDGenerator.GenerateID()
                
            };
            newCar.PrintInfo();
            newCar.Drive(10);

            var newFuelCar = new FuelCar()
            {
                CarBrand = "Toyota",
                CarModel = "Corrola",
                NumberOfDoors = 5,
                TopSpeed = 260,
                Consumption = Consumption.Medium,
                EngineType = EngineType.Diesel,
                CarId = CarIDGenerator.GenerateID()
            };

            newFuelCar.PrintInfo();
            newFuelCar.Drive(1000);
            newFuelCar.Refuel(100);


        }
    }
}
