using System;

namespace Lesson_04
{
    class Program
    {
        static void Main(string[] args)
        {

            // Loops

            int limit = 4;

            Console.WriteLine("-------------- while ------------------");
            int whileCounter = 0;
            // loop will run until the condition returns false
            while(whileCounter < limit)
            {
                Console.WriteLine(whileCounter);
                whileCounter++;
            }


            Console.WriteLine("-------------- do while ------------------");

            // loop will run at least one time
            int doWhileCounter = 0;
            do
            {
                Console.WriteLine(doWhileCounter);
                doWhileCounter++;
            } while (doWhileCounter < limit);



            Console.WriteLine("-------------- for ------------------");
            for (int forCounter = 0; forCounter < limit; forCounter++)
            {
                Console.WriteLine(forCounter);
            }

            Console.ReadKey();

            /*
             * Result: 
                -------------- while ------------------
                0
                1
                2
                3
                -------------- do while ------------------
                0
                1
                2
                3
                -------------- for ------------------
                0
                1
                2
                3


             */
        }
    }
}
