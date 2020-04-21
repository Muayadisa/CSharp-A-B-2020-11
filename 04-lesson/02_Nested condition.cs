using System;

namespace Lesson_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nested conditions:

            int age = 7;
            bool IsWinePerson = false;


            // (age < 0 || age > 120) - returns a boolean value
            if (age < 0 || age > 120)
            {
                Console.WriteLine("Invalid age!!");
            }
            else if(age < 25)
            {
                Console.WriteLine("You can only drink soft drink");
            }
            // Here is our nested condition - תנאי בתוך תנאי
            // here the person for valid age and (age > 25)
            else
            {
                if (IsWinePerson)
                {
                    Console.WriteLine("You can drink wine");
                }
                else
                {
                    Console.WriteLine("You can drink beer");
                }
            }

            Console.ReadKey();

        }
    }
}
