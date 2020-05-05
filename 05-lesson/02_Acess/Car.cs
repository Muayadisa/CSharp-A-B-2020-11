using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_05
{
    class Car
    {
        // Properties
        private int numOfWheels;

        //----------- Getter and Setter: ----------------
        public void SetNumOfWheels(int value)
        {
            if(value < 10 && value >=4) // validation check
                numOfWheels = value;
        }

        public int GetNumOfWheels()
        {
            return numOfWheels;
        }

        // Methods
        public string GetDescription()
        {
            return $" {numOfWheels} wheels";
        }
    }
}
