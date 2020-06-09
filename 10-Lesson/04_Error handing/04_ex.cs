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
                int num = int.Parse(str); 
                Console.WriteLine("End Try");
            }
            // FormatException - will catch any exception of this class, or sub-classes. 
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception. In catch");
            }
            finally
            {
                Console.WriteLine("Finally will always run. ");
            }
            Console.WriteLine("After try - catch");

            /*
            Start Try
            Input string was not in a correct format.
            Finally will always run.
            After try - catch

             */
            Console.ReadKey();
        }
    }
}
