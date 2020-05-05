using System;

namespace Lesson_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // new Car() - instance of Car class.
            Car c1 = new Car();

            c1.SetNumOfWheels(4);

            Console.WriteLine($"c1 has {c1.GetDescription()}");

            // new Car() - instance of Car class.
            Car c2 = new Car();

            c2.SetNumOfWheels(6);

            Console.WriteLine($"c2 has {c2.GetDescription()}");



            Console.ReadKey();
        }
        
    }
}
