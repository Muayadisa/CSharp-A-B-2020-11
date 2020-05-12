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
        private Date birthdate;
        public Date Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        // Composition: use the same class: 
        private Person father;
        public Person Father
        {
            get { return father; }
            set { father = value; }
        }

        private Person mother;
        public Person Mother
        {
            get { return mother; }
            set { mother = value; }
        }

        // Constructor: 
        public Person(string name, Date birthdate, Person father, Person mother)
        {
            Name = name;
            Birthdate = birthdate;
            Father = father;
            Mother = mother;
        }

        // return the data about each instance:
        public override string ToString()
        {
            // return if person does not have parents:
            string res = $"Person: {Name}, Birthdate: {Birthdate}";

            // add info if a person has parents:
            if (Father != null && Mother!= null)
            {
                res += $"\nFather: {Father.ToString()} \nMother: {Mother.ToString()}";
            }
            return res;
        }
    }
}
