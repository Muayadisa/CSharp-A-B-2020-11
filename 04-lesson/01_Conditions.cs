using System;

namespace Lesson_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conditions - תנאים

            bool flag = true;
            int num = 7;

            // --------- 1 option to use conditions: with boolean variable: ---------------

            // if statement always returns boolean value
            // when we use boolean variable in if statement there is no need to add ==
            if (flag)
            {
                // if flag == true
                Console.WriteLine("Flag is true");
            }
            else
            {
                // if flag == false
                Console.WriteLine("Flag is false");
            }

            if (!flag)
            {
                // if (!flag) the same as (flag == false)
                Console.WriteLine("Flag is false");
            }
            else
            {
                // if flag == true
                Console.WriteLine("Flag is true");
            }

            //------ 2 option to use conditions: with varaible that returns a boolean value ---------
            if(num < 8)
            {
                // if num is smaller than 8
                Console.WriteLine($"num: {num} is lt 8");
            }
            else
            {
                // if num is greater than 8
                Console.WriteLine($"num: {num} is gt 8");
            }

            // ------- 3 option to use contions: with direct boolean value (true/false)------------
            if (true)
            {
                Console.WriteLine("I am true");
            }
            // this will never happen: 
            else
            {
                Console.WriteLine("I am false");
            }

        /*
        Result:
        -------------
        Flag is true
        Flag is true
        num: 7 is lt 8
        I am true
        */

        }
    }
}
