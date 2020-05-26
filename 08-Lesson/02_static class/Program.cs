using System;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Operation amount: {Calculator.SumOfOperations}");

            // Calculator c1 = new Calculator(); - cannot create instance from static class. 

            int n1 = 25, n2 = 5;

            Console.WriteLine($"{n1} + {n2} = {Calculator.Calc(n1, n2, '+')}");
            Console.WriteLine($"{n1} - {n2} = {Calculator.Calc(n1, n2, '-')}");
            Console.WriteLine($"{n1} * {n2} = {Calculator.Calc(n1, n2, '*')}");
            Console.WriteLine($"{n1} / {n2} = {Calculator.Calc(n1, n2, '/')}");
            Console.WriteLine($"{n1} % {n2} = {Calculator.Calc(n1, n2, '%')}");

            Console.WriteLine($"Operation amount: {Calculator.SumOfOperations}");



            Console.ReadKey();
            /*
                Calculator class started!   -> this is the static ctor. (runs always). 
                Operation amount: 0
                25 + 5 = 30
                25 - 5 = 20
                25 * 5 = 125
                25 / 5 = 5
                25 % 5 = 0
                Operation amount: 5

                */
        }
    }
}
