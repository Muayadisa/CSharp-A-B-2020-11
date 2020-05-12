using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson06
{
    class ExDate
    {
        // Properties:

        private int day;
        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        private int month;
        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        // Constructor:
        public ExDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

    }
}
