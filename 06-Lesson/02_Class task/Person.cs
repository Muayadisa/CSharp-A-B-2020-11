using System;

namespace Lesson06
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

        // Composition:
        private Address addr;
        public Address Addr
        {
            get { return addr; }
            set { addr = value; }
        }

        // Constructor:
        public Person(string name, Address addr)
        {
            Name = name;
            Addr = addr;
        }

        // Get info:
        public string GetInfo()
        {
            return $"Person: {Name} lives in: \n{addr.GetInfo()}";
        }
    }
}
