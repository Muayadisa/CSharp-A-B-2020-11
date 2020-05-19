using System;

namespace Lesson07
{
    class Cinema
    {
        // Properties:
        private Movie[] movies;
        public Movie[] Movies
        {
            get { return movies; }
            set { movies = value; }
        }

        private Hall[] halls;
        public Hall[] Halls
        {
            get { return halls; }
            set { halls = value; }
        }


        // Constructor:
        public Cinema()
        {
            Movies = new Movie[100];
            Halls = new Hall[6];
        }

        // method - to buy a ticket to specific movie:
        public bool BuyTickets(string MovieName, int amount)
        {
            bool res = false;
            for (int i = 0; i < Halls.Length; i++)
                if (halls[i] != null && halls[i].HallMovie.MovieName == MovieName)
                    res = halls[i].BuySeats(amount);
            return res;
        }

        public override string ToString()
        {
            string res = "";

            for (int i = 0; i < Halls.Length; i++)
            {
                if(Halls[i] != null)
                {
                    res += $"\n--------------ROOM {i} -----------------\n";
                    res += Halls[i].ToString();
                }
            }
            return res;
        }
    }
}
