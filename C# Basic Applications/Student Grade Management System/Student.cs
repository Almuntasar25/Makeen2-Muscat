namespace ConsoleApp2
{
    internal class Student
    {
        //Assignment 4: Student Grade Management System
        static void Main(string[] args)
        {
                string[] students = new string[100];
                int[] grades = new int[100];
                int count = 0;

                while (true)
                {
                    Console.WriteLine("1 Add Student \r\n2 Update Grade \r\n3 View All" +
                        "\r\n4 Show Stats \n\r5 Exit");
                  
                    string c = Console.ReadLine();

                    if (c == "1")
                    {
                        Console.Write("Name: ");
                        students[count] = Console.ReadLine();
                        Console.Write("Grade: ");
                        int g = int.Parse(Console.ReadLine());
                        if (g >= 0 && g <= 100)
                        {
                            grades[count] = g;
                            count++;
                        }
                        else
                        {
                            Console.WriteLine("Invalid grade.");
                        }
                    }

                    else if (c == "2")
                    {
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        bool found = false;

                        for (int i = 0; i < count; i++)
                        {
                            if (students[i] == name)
                            {
                                Console.Write("New grade: ");
                                int g = int.Parse(Console.ReadLine());
                                if (g >= 0 && g <= 100)
                                {
                                    grades[i] = g;
                                    Console.WriteLine("Updated.");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid grade.");
                                }
                                found = true;
                                break;
                            }
                        }
                        if (!found) Console.WriteLine("Not found.");
                    }

                    else if (c == "3")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine(students[i] + " = " + grades[i]);
                        }
                    }

                    else if (c == "4")
                    {
                        if (count == 0) { Console.WriteLine("No data"); continue; }
                        int total = 0;
                        int high = grades[0];
                        int low = grades[0];
                        for (int i = 0; i < count; i++)
                        {
                            total += grades[i];
                            if (grades[i] > high) high = grades[i];
                            if (grades[i] < low) low = grades[i];
                        }
                        Console.WriteLine("Average = " + (total / count));
                        Console.WriteLine("Highest = " + high);
                        Console.WriteLine("Lowest = " + low);
                    }

                    else if (c == "5")
                    {
                        break;
                    }
                }
            }
        }

    
}
