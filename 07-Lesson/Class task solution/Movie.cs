using System;

namespace Lesson07
{
    class Movie
    {
        // Properties:
        private string movieName;
        public string MovieName
        {
            get { return movieName; }
            set { movieName = value; }
        }

        private int movieLen;
        public int MovieLen
        {
            get { return movieLen; }
            set {
                if(value > 0)
                    movieLen = value;
            }
        }

        // Constructor:
        public Movie(string movieName, int movieLen)
        {
            MovieName = movieName;
            MovieLen = movieLen;
        }

        // toString()
        public override string ToString()
        {
            return $"Movie: {MovieName}, length: {MovieLen}";
        }

        
    }
}
