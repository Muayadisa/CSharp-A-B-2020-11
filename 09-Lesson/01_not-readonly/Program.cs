using System;

namespace Lesson09
{
    class Program
    {
        static void Main(string[] args)
        {

            Car c1 = new Car("X");

            Console.WriteLine(c1); // Car from : X, NumOfWheels: 4

            c1.Company = "Y";

            Console.WriteLine(c1); // Car from : Y, NumOfWheels: 4

            Car.NumOfWheels = 5;

            Console.WriteLine(c1); // Car from : Y, NumOfWheels: 5

            Console.ReadKey();

        }
    }
}
