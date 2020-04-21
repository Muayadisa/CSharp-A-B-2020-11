using System;

namespace Lesson_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Short condition

            bool flag = true;
            string res1="", res2="";

            // regular condition:
            if (flag)
            {
                res1 = "flag is true";
            }
            // this now will not happen:
            else
            {
                res1 = "flag is false";
            }

            Console.WriteLine($"res1 = {res1}");

            // short condition:
            res2 = (flag) ? "flag is true" : "flag is false";

            Console.WriteLine($"res2 = {res2}");

            /*
             * Res:
               --------------------
               res1 = flag is true
               res2 = flag is true
            */

            Console.ReadKey();

        }
    }
}
