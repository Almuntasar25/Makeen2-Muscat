namespace Library_Book_Borrowing_System
{
    internal class LibrarySystem
    {
        static void Main(string[] args)
        {
            string[] books = new string[5];
            bool[] isBorrowed = new bool[5];

            books[0] = "C# Programming";
            books[1] = "Data Structures";
            books[2] = "Database Systems";
            books[3] = "Operating Systems";
            books[4] = "Computer Networks";

            for (int i = 0; i < 5; i++)
            {
                isBorrowed[i] = false;
            }

            bool running = true;

            while (running)
            {
                Console.WriteLine("1. View Books");
                Console.WriteLine("2. Borrow Book");
                Console.WriteLine("3. Return Book");
                Console.WriteLine("4. Check Availability");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Book List:");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write((i + 1) + ". " + books[i] + " - ");
                            if (isBorrowed[i])
                            {
                                Console.WriteLine("Borrowed");
                            }
                            else
                            {
                                Console.WriteLine("Available");
                            }
                        }
                        break;

                    case 2:
                        Console.Write("Enter book number to borrow (1-5): ");
                        int borrowIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (borrowIndex >= 0 && borrowIndex < 5)
                        {
                            if (isBorrowed[borrowIndex] == false)
                            {
                                isBorrowed[borrowIndex] = true;
                                Console.WriteLine("Book borrowed successfully.");
                            }
                            else
                            {
                                Console.WriteLine("This book is already borrowed.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid book number.");
                        }
                        break;

                    case 3:
                        Console.Write("Enter book number to return (1-5): ");
                        int returnIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (returnIndex >= 0 && returnIndex < 5)
                        {
                            if (isBorrowed[returnIndex] == true)
                            {
                                isBorrowed[returnIndex] = false;
                                Console.WriteLine("Book returned successfully.");
                            }
                            else
                            {
                                Console.WriteLine("This book is not currently borrowed.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid book number.");
                        }
                        break;

                    case 4:
                        Console.Write("Enter book number to check availability (1-5): ");
                        int checkIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (checkIndex >= 0 && checkIndex < 5)
                        {
                            if (isBorrowed[checkIndex] == false)
                            {
                                Console.WriteLine("The book is available.");
                            }
                            else
                            {
                                Console.WriteLine("The book is borrowed.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid book number.");
                        }
                        break;

                    case 5:
                        running = false;
                        Console.WriteLine("Exiting Library System.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine(); 
            }
        }
    }
    }

