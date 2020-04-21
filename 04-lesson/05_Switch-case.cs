using System;

namespace Lesson_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Switch - case:

            int num = 6;

            // if there is content in the case - we must add break statement. 
            switch (num)
            {
                case 1: Console.WriteLine("I am 1"); break;
                case 2: Console.WriteLine("I am 2"); break;
                default:Console.WriteLine("I am not 1 or 2"); break;
            }

            switch (num)
            {
                case 1: Console.WriteLine("Sunday"); break;
                case 2: Console.WriteLine("Monday"); break;
                case 5:
                case 6:
                case 7: Console.WriteLine("Weekend"); break;
                default: Console.WriteLine("not sunday or monday"); break;
            }
            Console.ReadKey();

            /*
             * Result: 
             * ----------------------
             *  I am not 1 or 2
                Weekend
             */
        }
    }
}
