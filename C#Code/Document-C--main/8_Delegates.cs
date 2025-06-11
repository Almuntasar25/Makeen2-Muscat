internal class Report
{
    // Define a delegate that takes an Employee object and returns a boolean (true or false)
    // This will be used to decide whether an employee meets a certain sales condition
    public delegate bool SalesConditon(Employee e);

    // Method to process and display employees who meet a certain condition
    public void processEmployee(Employee[] emp, string Title, SalesConditon cond)
    {
        // Print the report title
        Console.WriteLine(Title);
        Console.WriteLine("------------------------");

        // Loop through each employee in the array
        foreach (Employee e in emp)
        {
            // Check if the employee meets the condition (using the delegate)
            if (cond(e))
            {
                // If true, print the employee details
                Console.WriteLine($"{e.id} | {e.id} |{e.gender} | {e.Totalsale}");
            }
        }

        // Add some spacing after the report
        Console.WriteLine("\n\n");
    }
}
