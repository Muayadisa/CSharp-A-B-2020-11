using System;

namespace Lesson_05
{
    class Cookie
    {
        // Gloten:
        private bool gloten;

        public bool Gloten
        {
            get { return gloten; }
            set { gloten = value; }
        }

        // NumOfEggs
        private int numOfEggs;

        public int NumOfEggs
        {
            get { return numOfEggs; }
            set { numOfEggs = value; }
        }

        // Sugar
        private float sugar;

        public float Sugar
        {
            get { return sugar; }
            set { sugar = value; }
        }

        // flour
        private float flour;

        public float Flour
        {
            get { return flour; }
            set { flour = value; }
        }
    }
}
