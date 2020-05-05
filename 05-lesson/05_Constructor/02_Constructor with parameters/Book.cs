using System;

namespace Lesson_05
{
    class Book
    {
        // Properties
        private string bookName;

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }

        private int numOfPages;

        public int NumOfPages
        {
            get { return numOfPages; }
            set { numOfPages = value; }
        }

        // -------- Constructor with variables from user ------------------
        public Book(string bookName, int numOfPages)
        {
            BookName = bookName;
            NumOfPages = numOfPages;
        }

        // -------- Constructor without variables ------------------
        public Book()
        {

        }

    }
}
