using System;

namespace Lesson8
{
    class Employee:Person
    {
        // Properties:
        private int idNumber;
        public int IdNumber
        {
            get { return idNumber; }
            set { idNumber = value; }
        }

        private string level;
        public string Level
        {
            get { return level; }
            set { level = value; }
        }

        // Constructor: (use parent class)
        public Employee(int idNumber, string level, string name, int age): base (name, age)
        {
            IdNumber = idNumber;
            Level = level;
        }

        // get info
        public override string ToString()
        {
            return $"{base.ToString()}\nIdNumber: {idNumber}, level: {level}";
        }
    }
}
