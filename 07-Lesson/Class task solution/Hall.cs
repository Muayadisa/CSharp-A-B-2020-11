using System;

namespace Lesson07
{
    class Hall
    {
        /*
        Hall 
        props: movie, seats, 
        methods: order seats
        */

        // Properties:

        // Create movie property - composition:
        private Movie hallMovie;
        public Movie HallMovie
        {
            get { return hallMovie; }
            set { hallMovie = value; }
        }

        // seats - matrix: 
        private bool[][] seats;
        public bool[][] Seats
        {
            get { return seats; }
            set { seats = value; }
        }

        // Constructor:
        public Hall(Movie hallMovie)
        {
            // Movie for each room - get from the program: 
            HallMovie = hallMovie;

            // initialize each matrix 10*8:
            Seats = new bool[10][];
            for (int row = 0; row < Seats.Length; row++)
                Seats[row] = new bool[8];
        }


        // method to buy seats:
        public bool BuySeats(int amount)
        {
            // check if there are enough seats:
            int counter = 0;
            for (int row = 0; row < Seats.Length; row++)
                for (int col = 0; col < Seats[row].Length; col++)
                    if(Seats[row][col] == false)
                        counter++;
                    
            // if number of empty seats is less than the desired amount - exit with false. 
            if (counter < amount)
                return false;

            // else - buy seats: 
              for (int row = 0; row < Seats.Length; row++)
               {
                for (int col = 0; col < Seats[row].Length; col++)
                {
                    if (Seats[row][col] == false)
                    {
                        Seats[row][col] = true;
                        amount--;

                        if (amount == 0)
                            break;
                    }
                }
                if (amount == 0)
                    break;
            }
            return true;
        }
        

        // toString()
        public override string ToString()
        {
            string res = $"{HallMovie.ToString()}";
            res += "\nSeats: V = full, X = empty\n";
            foreach (bool[] row in Seats)
            {
                foreach (bool col in row)
                {
                    res += (col) ? " V " : " X ";
                }
                res += "\n";
            }

            return res;
        }
    }
}
