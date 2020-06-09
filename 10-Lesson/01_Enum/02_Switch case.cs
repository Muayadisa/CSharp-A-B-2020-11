using System;

namespace Lesson10
{

    enum Level
    {
        HIGH, 
        MEDIUM, 
        LOW
    }

    class Program
    {
        static void Main(string[] args)
        {
            Level l1 = Level.HIGH;

            // Enums are often used in switch-case:

            switch (l1)
            {
                case Level.LOW:
                    Console.WriteLine("Low level");
                    break;
                case Level.MEDIUM:
                    Console.WriteLine("medium level");
                    break;
                case Level.HIGH:
                    Console.WriteLine("High level");
                    break;
            }

            // High level

            Console.ReadKey();
        }
    }
}
