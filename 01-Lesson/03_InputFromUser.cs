using System;

namespace _01_HelloWorld1
{
    class Program
    {        
        static void Main(string[] args)
        {
            string str;

            Console.WriteLine("Say something: ");

            // `ReadLine() ` - a function that returns the input from the keyboard string. 
            // note: ReadLine() - gets the input in a string shape. 
            str = Console.ReadLine();

            Console.WriteLine($"You said: {str}");

            Console.WriteLine($"2+5 = {2+5}");
            
            // optional
            Console.ReadKey();

        }
    }
}
