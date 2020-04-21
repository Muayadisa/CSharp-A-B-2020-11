using System;

namespace Lesson_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Functions

            PrintHello();    //--> Hello user!
            PrintSun(3, 5); // --> 3 + 5 = 8
            string str = GetHello(); // this will receive the returned value from GetHello()
            Console.WriteLine($"Got from GetHello(): {str}");

            int num = GetSum(4,8);
            Console.WriteLine($"Got from GetSum(): {num}"); //--> Got from GetSum(): 12

            Console.ReadKey();
        }

        // Basic function. returns void (nothing), and does not get parameters
        static void PrintHello()
        {
            Console.WriteLine("Hello user!");
        }

        // Function that gets two numbers, and prints the sum of them. 
        static void PrintSun(int num1, int num2 )
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }

        static string GetHello()
        {
            return "Hello from GetHello()";
        }


        static int GetSum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
