using System;

namespace Lesson8
{
    class Person
    {
        // Properties:
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        // constructor:
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // return info
        public override string ToString()
        {
            return $"Person: {name} is {age} years old";
        }
    }
}
