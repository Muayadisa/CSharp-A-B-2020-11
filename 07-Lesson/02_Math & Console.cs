using System;

namespace Lesson07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Static class - we cannot create instances from. 
            // click on the class, and F12 - goes to the class definition. 
            // Math m1 = new Math(); -> error
            Console.WriteLine(Math.Sqrt(4)); // 2

            // Everything in bright-blue - is a class. 
            // Console c1 = new Console(); -> error

            Console.ReadKey();
        }
    }
}
