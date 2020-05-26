using System;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "A", "Bob", 40);
            Employee e2 = new Employee(2, "B", "Alice", 50);
            Employee e3 = new Employee(3, "A", "John", 60);

            Console.WriteLine(e1); 
            // writing the name of the instance - goes to toString()
        }
    }
}