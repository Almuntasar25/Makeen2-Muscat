using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Class_System__Easy_
{
    internal class Book
    {

        private string Title;
        private string Author;
        private int Year;
        private string Isbn;

        public Book(string title, string author, int year, string isbn)
        {
            Title = title;
            Author = author;
            Year = year;
            Isbn = isbn;
        }

        public void PrintBookInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("ISBN: " + Isbn);
        }

        public bool IsOlderThan(int Y)
        {
            if (Year < Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

