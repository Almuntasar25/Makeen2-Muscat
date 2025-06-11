namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 5: Parking Lot System

                int[] slots = new int[10];

                for (int i = 0; i < 10; i++)
                {
                    slots[i] = 0;
                }

                bool running = true;

                while (running)
                {
                    Console.WriteLine("1. Park a Car");
                    Console.WriteLine("2. Remove a Car");
                    Console.WriteLine("3. View All Slots");
                    Console.WriteLine("4. Search for a Car");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice: ");

                    string input = Console.ReadLine();
                    int choice = Convert.ToInt32(input);

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter car license number to park: ");
                            int carToPark = Convert.ToInt32(Console.ReadLine());

                            bool duplicate = false;
                            for (int i = 0; i < 10; i++)
                            {
                                if (slots[i] == carToPark)
                                {
                                    duplicate = true;
                                }
                            }

                            if (duplicate)
                            {
                                Console.WriteLine("This car is already parked.");
                            }
                            else
                            {
                                bool parked = false;
                                for (int i = 0; i < 10; i++)
                                {
                                    if (slots[i] == 0)
                                    {
                                        slots[i] = carToPark;
                                        Console.WriteLine("Car parked at slot " + (i + 1));
                                        parked = true;
                                        break;
                                    }
                                }

                                if (!parked)
                                {
                                    Console.WriteLine("Parking lot is full.");
                                }
                            }

                            break;

                        case 2:
                            Console.Write("Enter car license number to remove: ");
                            int carToRemove = Convert.ToInt32(Console.ReadLine());
                            bool found = false;

                            for (int i = 0; i < 10; i++)
                            {
                                if (slots[i] == carToRemove)
                                {
                                    slots[i] = 0;
                                    Console.WriteLine("Car removed from slot " + (i + 1));
                                    found = true;
                                    break;
                                }
                            }

                            if (!found)
                            {
                                Console.WriteLine("Car not found.");
                            }

                            break;

                        case 3:
                            Console.WriteLine("Parking Slots Status:");
                            for (int i = 0; i < 10; i++)
                            {
                                Console.Write("Slot " + (i + 1) + ": ");
                                if (slots[i] == 0)
                                {
                                    Console.WriteLine("Empty");
                                }
                                else
                                {
                                    Console.WriteLine("Car " + slots[i]);
                                }
                            }

                            break;

                        case 4:
                            Console.Write("Enter car license number to search: ");
                            int carToSearch = Convert.ToInt32(Console.ReadLine());
                            bool exists = false;

                            for (int i = 0; i < 10; i++)
                            {
                                if (slots[i] == carToSearch)
                                {
                                    Console.WriteLine("Car found at slot " + (i + 1));
                                    exists = true;
                                    break;
                                }
                            }

                            if (!exists)
                            {
                                Console.WriteLine("Car not found in the parking lot.");
                            }

                            break;

                        case 5:
                            running = false;
                            Console.WriteLine("Exiting the system.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }

                    Console.WriteLine(); 
                }
            }
        }

    }


