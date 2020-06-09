using System;

namespace Lesson10
{

    enum Season
    {
        Authumn,
        Winter, 
        Summer, 
        Spring
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Enum - enumeration type. 
            Season s1 = Season.Spring;
            Console.WriteLine(s1); // Spring

            Season s2 = (Season)2;
            Console.WriteLine(s2); // Summer


            Console.ReadKey();
        }
    }
}
