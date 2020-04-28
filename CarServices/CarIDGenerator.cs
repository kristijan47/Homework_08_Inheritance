using System;
using System.Collections.Generic;
using System.Text;

namespace CarServices
{
   public class CarIDGenerator
    {
        public static int GenerateID()
        {
            Random rand = new Random();
            int ID = rand.Next(99999, 1000000);
            return ID;
        }
    }
}
