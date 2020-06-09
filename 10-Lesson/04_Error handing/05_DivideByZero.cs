using System;

namespace Lesson10
{

    class TryException
    {
        public static double TryDivision(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // zero divition. 
            double a = 43, b = 0;
            try
            {
                Console.WriteLine(TryException.TryDivision(a, b)); 
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Attempted to divide by zero.
            Console.ReadKey();
        }
    }
}
