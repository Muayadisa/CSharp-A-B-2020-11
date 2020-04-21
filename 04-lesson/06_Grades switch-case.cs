using System;

namespace Lesson_04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                grades:
                90 - 100: perfect
                80 - 90 : very good
                60 - 80 : good
                0 - 60 : try to improve
            */

            int[] grades = new int[]{100, 64, 32, 88, 53, 72};

            foreach (int grade in grades)
            {
                Console.WriteLine($"-----grade: {grade} ------");

                switch (grade/10)
                {
                    case 10:
                    case 9: Console.WriteLine("Perfect"); break;
                    case 8: Console.WriteLine("Very good"); break;
                    case 7:
                    case 6: Console.WriteLine("Good"); break;
                    default: Console.WriteLine("Try to improve! "); break;
                }
            }



            Console.ReadKey();

            /*
             * Result: 
               ----------------------
                -----grade: 100 -----
                Perfect
                -----grade: 64 ------
                Good
                -----grade: 32 ------
                Try to improve!
                -----grade: 88 ------
                Very good
                -----grade: 53 ------
                Try to improve!
                -----grade: 72 ------
                Good

             */
        }
    }
}
