using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8
{
    static class Calculator
    {

        private static int sumOfOperations;
        public static int SumOfOperations
        {
            get { return sumOfOperations; }
            set { sumOfOperations = value; }
        }

        static Calculator()
        {
            Console.WriteLine("Calculator class started!");
        }

        public static int Calc(int n1, int n2, char operation)
        {
            SumOfOperations++;

            switch (operation)
            {
                case '+': return n1 + n2;
                case '-': return n1 - n2;
                case '*': return n1 * n2;
                case '/': return n1 / n2;
                case '%': return n1 % n2;
            }
            return 0;
        }

    }
}
