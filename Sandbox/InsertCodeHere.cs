﻿using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            CarPool pool = new CarPool();

            pool.AddCarToPool(new Car("CF 32 556", "Ford", "Mondeo"));
            pool.AddCarToPool(new Car("AG 57 109", "Ford", "Fiesta"));
            pool.AddCarToPool(new Car("DE 44 006", "BMW", "320i"));
            pool.AddCarToPool(new Car("DK 54 236", "Opel", "Karl"));

            // Pool should now contain the three cars given above
            Console.WriteLine("The Car Pool now contains:");
            pool.PrintAllCarsInPool();
            Console.WriteLine();

            pool.RemoveCarFromPool("AG 57 109");
            pool.RemoveCarFromPool("DOES NOT EXIST");

            // Pool should now contain two cars
            Console.WriteLine("The Car Pool now contains:");
            pool.PrintAllCarsInPool();
            Console.WriteLine();

            // The LAST line of code should be ABOVE this line
        }
    }
}
