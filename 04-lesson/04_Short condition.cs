using System;

namespace Lesson_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Short condition
            /*
             if(num > 9) : res = (num * 2)
             if(num <= 9): res = (num - 4)
             */

            int num = 5;
            int res = (num > 9) ? (num * 2) : (num - 4);

            Console.WriteLine($"num is: {num}, res is: {res}");

            Console.ReadKey();

            /*
             * Result: 
             * ----------------------
             * num is: 5, res is: 1
             */
        }
    }
}
