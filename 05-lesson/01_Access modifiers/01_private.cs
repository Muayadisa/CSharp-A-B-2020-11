using System;

namespace Lesson_05
{
    class Car
    {
        // Properties
        private int NumOfWheels = 4;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            // Console.WriteLine($"NumOfWheels: {c1.NumOfWheels}");
            // 'Car.NumOfWheels' is inaccessible due to its protection level  

            Console.ReadKey();
        }
        
    }
}
