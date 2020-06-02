using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson09
{
    class Car
    {

        // Properties:

        // readonly - cannot be assigned to. (except from a static constructor or variable initialize)
        public static readonly int NumOfWheels = 4;

        // readonly - cannot be assigned to. (except from a constructor or variable initialize)
        public readonly string  Company = "A";


        // Constructor:
        public Car(string company)
        {
            Company = company;
        }


        public override string ToString()
        {
            return $"Car from : {Company}, NumOfWheels: {NumOfWheels}";
        }
    }
}
