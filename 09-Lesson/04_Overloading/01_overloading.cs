  class Car
    {
        // Properties:
        private int color;
        public int Color
        {
            get { return color; }
            set { color = value; }
        }

        private string company;
        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        // Constructor - overloading:
        public Car()
        {

        }

        public Car(int color)
        {
            Color = color;
        }

        public Car(int color, string company)
        {
            Color = color;
            Company = company;
        
        }

    }