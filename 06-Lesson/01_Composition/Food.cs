using System;

namespace Lesson06
{
    class Food
    {
        // Properties:
        private string foodName;
        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; }
        }

        // Composition 
        private ExDate lastDate;
        public ExDate LastDate
        {
            get { return lastDate; }
            set { lastDate = value; }
        }

        public string GetDescription()
        {
            string exdate = $"{LastDate.Year}/{LastDate.Month}/{LastDate.Day} ";
            string res = $"{foodName} expiration date: " + exdate;
            return res;
        }


    }
}
