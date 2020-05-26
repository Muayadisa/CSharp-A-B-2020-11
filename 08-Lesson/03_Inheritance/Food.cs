using System;

namespace Lesson8
{
    class Food
    {
        // Properties:
        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private bool isVeg;
        public bool IsVeg
        {
            get { return isVeg; }
            set { isVeg = value; }
        }
    }
}
