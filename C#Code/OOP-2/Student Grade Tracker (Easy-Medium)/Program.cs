namespace Student_Grade_Tracker__Easy_Medium_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ali", 103);
            Student student2 = new Student("Ahmed", 105);

            student1.AddGrade(85);
            student1.AddGrade(90);
            student1.AddGrade(78);

            student2.AddGrade(92);
            student2.AddGrade(88);

            student1.PrintStudentReport();
            student2.PrintStudentReport();
        }
    }
}
    

