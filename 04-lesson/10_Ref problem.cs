using System;

namespace Lesson_04
{
    class Program
    {
        // Function to replace the value of the two variables: 
        static void ChangeNum(int n1, int n2)
        {
            Console.WriteLine($"n1: {n1}, n2: {n2}");
            int temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine($"n1: {n1}, n2: {n2}");
        }


        static void Main(string[] args)
        {
            int num1 = 2, num2 = 8;

            Console.WriteLine($"BEFORE: -------------num1: {num1}, num2: {num2}");

            ChangeNum(num1, num2);

            Console.WriteLine($"AFTER: -------------num1: {num1}, num2: {num2}");

            Console.ReadKey();
        }

        /*
         * RESULT: 
          -------------------------------------------
            BEFORE: -------------num1: 2, num2: 8
            n1: 2, n2: 8
            n1: 8, n2: 2
            AFTER: -------------num1: 2, num2: 8

        Explanation:
        When we send a variable to a function, and change it inside the function, 
        The variable doesn't change its value. 
        The reason: n1 will get the value inside num1, and not the address of that variable. 
        
         */
      
    }
}
