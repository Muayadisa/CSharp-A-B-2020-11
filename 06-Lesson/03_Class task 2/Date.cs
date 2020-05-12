using System;

namespace Lesson06
{
    class Date
    {
        // Properties:
        private int year;
        public int Year
        {
            get { return year; }
            set { if(value > 0)
                year = value; }
        }

        private int month;
        public int Month
        {
            get { return month; }
            set {
                if(value > 0 && value <=12)
                month = value;
            }
        }

        private int day;
        public int Day
        {
            get { return day; }
            set {
                if(value > 0 && value <= 31)
                day = value;
            }
        }

        // Constructor: 
        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        // Override the built-in function ToString()
        public override string ToString()
        {
            return $"Date: {Year}/{Month}/{Day}";
        }
    }
}
