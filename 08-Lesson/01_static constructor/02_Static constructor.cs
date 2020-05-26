using System;

namespace Lesson8
{
    class User
    {
        public static int enterAge;

        // Regular constructor:
        public User(string name)
        {
            Console.WriteLine($"Name is : {name}");
        }

        // static constructor:
        static User()
        {
            enterAge = 18;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(User.enterAge);
            User p1 = new User("John");
            User p2 = new User("Tom");
            User p3 = new User("Alice");

            

            Console.ReadKey();
            /*
                This is a static constructor!
                Name is : John
                Name is : Tom
                Name is : Alice
                */
        }
    }
}
