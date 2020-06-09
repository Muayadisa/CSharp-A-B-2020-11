using System;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            // problematic code: 
            string str = "Hello";

            try
            {
                Console.WriteLine("Start Try");
                int num = int.Parse(str); // System.FormatException: 'Input string was not in a correct format.'
                Console.WriteLine("End Try");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("OutOfMemoryException. In catch");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception. In catch");
            }
            Console.WriteLine("After try - catch");
            /*
                Start Try
                Exception. In catch
                After try - catch

             */
            Console.ReadKey();
        }
    }
}
