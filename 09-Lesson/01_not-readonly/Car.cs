using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson09
{
    class Car
    {
        // Properties:
        public static int NumOfWheels = 4;
        public string Company = "A";


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
