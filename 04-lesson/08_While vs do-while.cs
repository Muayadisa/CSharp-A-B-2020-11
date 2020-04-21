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
            int whileCounter = 4;
            // loop will not run because the condition is false. 
            while(whileCounter < limit)
            {
                Console.WriteLine(whileCounter);
                whileCounter++;
            }


            Console.WriteLine("-------------- do while ------------------");

            // loop will run one time
            int doWhileCounter = 4;
            do
            {
                Console.WriteLine(doWhileCounter);
                doWhileCounter++;
            } while (doWhileCounter < limit);



          

            Console.ReadKey();

            /*
             * Result: 
                -------------- while ------------------
                -------------- do while ------------------
                4



             */
        }
    }
}
