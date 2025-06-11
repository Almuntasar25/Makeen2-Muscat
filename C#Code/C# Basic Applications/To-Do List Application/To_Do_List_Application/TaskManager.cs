namespace To_Do_List_Application.NewFolder
{
    internal class TaskManager
    {
        static void Main(string[] args)
        {
            string[] tasks = new string[100];
            bool[] isCompleted = new bool[100];
            int count = 0;
            bool running = true;

            while (running)
            {
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Delete Task");
                Console.WriteLine("3. Mark Task as Completed");
                Console.WriteLine("4. View Tasks");
                Console.WriteLine("5. Clear Completed Tasks");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (count >= 100)
                        {
                            Console.WriteLine("Task list is full.");
                        }
                        else
                        {
                            Console.Write("Enter task description: ");
                            string newTask = Console.ReadLine();
                            tasks[count] = newTask;
                            isCompleted[count] = false;
                            count++;
                            Console.WriteLine("Task added.");
                        }
                        break;

                    case 2:
                        Console.Write("Enter task number to delete (starting from 1): ");
                        int deleteIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (deleteIndex >= 0 && deleteIndex < count)
                        {
                            for (int j = deleteIndex; j < count - 1; j++)
                            {
                                tasks[j] = tasks[j + 1];
                                isCompleted[j] = isCompleted[j + 1];
                            }
                            count--;
                            Console.WriteLine("Task deleted.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid task number.");
                        }
                        break;

                    case 3:
                        Console.Write("Enter task number to mark as completed (starting from 1): ");
                        int completeIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (completeIndex >= 0 && completeIndex < count)
                        {
                            isCompleted[completeIndex] = true;
                            Console.WriteLine("Task marked as completed.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid task number.");
                        }
                        break;

                    case 4:
                        if (count == 0)
                        {
                            Console.WriteLine("No tasks to display.");
                        }
                        else
                        {
                            Console.WriteLine("Your Tasks:");
                            for (int h = 0; h < count; h++)
                            {
                                Console.Write((h + 1) + "." + tasks[h] + " - ");
                                if (isCompleted[h])
                                {
                                    Console.WriteLine("Done");
                                }
                                else
                                {
                                    Console.WriteLine("Pending");
                                }
                            }
                        }
                        break;

                    case 5:
                        int i = 0;
                        while (i < count)
                        {
                            if (isCompleted[i])
                            {
                                for (int j = i; j < count - 1; j++)
                                {
                                    tasks[j] = tasks[j + 1];
                                    isCompleted[j] = isCompleted[j + 1];
                                }
                                count--;
                            }
                            else
                            {
                                i++;
                            }
                        }
                        Console.WriteLine("Completed tasks cleared.");
                        break;

                    case 6:
                        running = false;
                        Console.WriteLine("Exiting Task Manager.");
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
    

