using System;

namespace Lesson8
{
    class A
    {
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
    class B
    {
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return $"age: {age}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            A a1 = new A();
            Console.WriteLine(a1.ToString()); // Lesson8.A
            Console.WriteLine(a1);            // Lesson8.A

            B b1 = new B();
            Console.WriteLine(b1.ToString()); // age: 0
            Console.WriteLine(b1);            // age: 0

            Console.ReadKey();
        }
    }
}
