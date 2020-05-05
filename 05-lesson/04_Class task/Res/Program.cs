using System;

namespace Lesson_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Cookie c1 = new Cookie();
            c1.Gloten = true;
            c1.NumOfEggs = 3;
            c1.Sugar = 2.5f;
            c1.Flour = 1.5f;

            Console.WriteLine(printDetails(c1));

            Console.ReadKey();
        }

        public static string printDetails(Cookie c)
        {
            string res = "Details of cookie: \n";
            res += $"Gloten: {c.Gloten}\n";
            res += $"NumOfEggs: {c.NumOfEggs}\n";
            res += $"Sugar: {c.Sugar}\n";
            res += $"Flour: {c.Flour}\n";

            return res;
        }
        
    }
}
