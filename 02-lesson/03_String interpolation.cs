using System;

namespace lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            // string interpolation 
            // interpolation - שרבוב או קריאת ביניים

            string str = "Hello";

            Console.WriteLine($"1 + 1 = {1+1}");  // --> 1 + 1 = 2
            Console.WriteLine($"msg is : {str}"); // --> msg is : Hello
        }
    }
}
