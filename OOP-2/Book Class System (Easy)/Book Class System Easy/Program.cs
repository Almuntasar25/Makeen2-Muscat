namespace Book_Class_System__Easy_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1956, "3988834");
            Book book2 = new Book("Clean Code", "Robert C. Martin", 2003, "48783348348");
            Book book3 = new Book("1984", "George Orwell", 1943, "95384583738");

            book1.PrintBookInfo();
            Console.WriteLine("Is older than 1950: " + book1.IsOlderThan(1950));

            book2.PrintBookInfo();
            Console.WriteLine("Is older than 2010: " + book2.IsOlderThan(2010));

            book3.PrintBookInfo();
            Console.WriteLine("Is older than 1950: " + book3.IsOlderThan(1950));
        }
    }
}
    

