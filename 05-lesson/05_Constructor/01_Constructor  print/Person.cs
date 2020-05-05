using System;

namespace Lesson_05
{
    class Person
    {
        // Properties
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // -------- Constructor ------------------
        // Will always run one time each time we create an instance of class `Person`
        public Person()
        {
            Console.WriteLine("New person was created! ");
        }

        // Methods
        public string GetDescription()
        {
            return $"Name: {Name}, Age: {Age}";
        }

    }
}
