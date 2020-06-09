using System;

namespace Lesson10
{

    enum Days
    {
           None     = 0, 
           Monday   = 1, 
           Tuesday  = 2, 
           Wendsday = 4, 
           Thursday = 8, 
           Friday   = 16,
           Saturday = 32,
           Sunday    = 64,
           Weekend   = Saturday | Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // create enum of colors - with 5 colors. 
            // in main: create instance of some color, and with switch case - print an object with this color. 
            // example: red - print: rose


            Days WorkDays = Days.Monday | Days.Thursday | Days.Wendsday;
            Console.WriteLine(WorkDays); // 13

            Days d1 = Days.Monday;
            Console.WriteLine(d1); // Monday

            Console.ReadKey();
        }
    }
}
