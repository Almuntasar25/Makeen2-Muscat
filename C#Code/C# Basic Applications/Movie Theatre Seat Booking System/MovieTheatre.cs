namespace Movie_Theatre_Seat_Booking_System
{
    internal class MovieTheatre
    {
        static void Main(string[] args)
        {
            char[,] seats = new char[5, 5];

            // Initialize all seats as available
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    seats[row, col] = 'A';
                }
            }

            bool running = true;

            while (running)
            {
                Console.WriteLine("1. View Seats");
                Console.WriteLine("2. Book Seat");
                Console.WriteLine("3. Cancel Booking");
                Console.WriteLine("4. Show Available Seat Count");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Seat Layout:");
                        for (int row = 0; row < 5; row++)
                        {
                            for (int col = 0; col < 5; col++)
                            {
                                Console.Write(seats[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        Console.Write("Enter row number (0 to 4): ");
                        int bookRow = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter column number (0 to 4): ");
                        int bookCol = Convert.ToInt32(Console.ReadLine());

                        if (bookRow >= 0 && bookRow < 5 && bookCol >= 0 && bookCol < 5)
                        {
                            if (seats[bookRow, bookCol] == 'A')
                            {
                                seats[bookRow, bookCol] = 'X';
                                Console.WriteLine("Seat booked successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Seat is already booked.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid seat position.");
                        }
                        break;

                    case 3:
                        Console.Write("Enter row number to cancel (0 to 4): ");
                        int cancelRow = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter column number to cancel (0 to 4): ");
                        int cancelCol = Convert.ToInt32(Console.ReadLine());

                        if (cancelRow >= 0 && cancelRow < 5 && cancelCol >= 0 && cancelCol < 5)
                        {
                            if (seats[cancelRow, cancelCol] == 'X')
                            {
                                seats[cancelRow, cancelCol] = 'A';
                                Console.WriteLine("Booking cancelled.");
                            }
                            else
                            {
                                Console.WriteLine("Seat is not booked.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid seat position.");
                        }
                        break;

                    case 4:
                        // Show count of available seats
                        int count = 0;

                        for (int row = 0; row < 5; row++)
                        {
                            for (int col = 0; col < 5; col++)
                            {
                                if (seats[row, col] == 'A')
                                {
                                    count = count + 1;
                                }
                            }
                        }

                        Console.WriteLine("Available seats: " + count);
                        break;

                    case 5:
                        running = false;
                        Console.WriteLine("Exiting the system.");
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

