using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_08_Inheritance.Models
{
    public class ElectricCar:Car
    {
        public int BatteryCapacity = 100;
        public int BatteryUsage;

        public void Recharge(int minutes)
        {
            var recharge = minutes * 10;

            if (minutes == 100 * 10)
            {
                Console.WriteLine($"Can't charge longer that {minutes} minutes");
            }
            else
            {
                BatteryCapacity += recharge;
                Console.WriteLine($"The Battery has been charged for {recharge}%!");
            }

        }
    }

    
}
