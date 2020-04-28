using Homework_08_Inheritance.Enums;
using CarServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_08_Inheritance.Models
{
    public class Car
    {
        public Car()
        {

        }

        public int CarId = CarIDGenerator.GenerateID();
        public string CarBrand;
        public string CarModel;
        public int NumberOfDoors;
        public int TopSpeed;
        public EngineType EngineType;
        public Consumption Consumption;

        public void PrintInfo()
        {
            Console.WriteLine(
                $"Brand:  {CarBrand} \n"+
                $"Car Model: {CarModel} \n" +
                $"Number Of Doors: {NumberOfDoors} \n" +
                $"Top Speed: {TopSpeed} \n" +
                $"Engine Type : {EngineType}\n"+
                $"Fuel Consumption : {Consumption}\n"+
                $"Car ID = {CarId}"



                );
        }

        public int Drive(int distance)
        {
            var drive = distance * (int)Consumption / 10;
            Console.WriteLine($" You Have Used {drive} liters of fuel");
            return drive;
        }
    }
}
