using System;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "2";
            int num = int.Parse(str); // converts from int to string. 
            Console.WriteLine(num);

            // problematic code: 
            string str2 = "Hello";

            try
            {
                Console.WriteLine("Start Try");
                int num2 = int.Parse(str2); // System.FormatException: 'Input string was not in a correct format.'
                Console.WriteLine(num2);
                Console.WriteLine("End Try");
            }
            catch(FormatException)
            {
                Console.WriteLine("FormatException. In catch");
            }
            Console.WriteLine("After try - catch");


            /*
                2
                Start Try
                FormatException. In catch
                After try - catch

             */
            Console.ReadKey();
        }
    }
}
