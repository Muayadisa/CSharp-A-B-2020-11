using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_05
{
    class Car
    {
        //----------- Getter and Setter: ----------------
        // Shortcut: Propfull + tab 
        private int numOfWheels;

        public int NumOfWheels
        {
            get { return numOfWheels; }
            set {
                if (value < 10 && value >= 4) // validation check
                    numOfWheels = value;
            }
        }


        // Methods
        public string GetDescription()
        {
            return $" {numOfWheels} wheels";
        }
    }
}
