using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grade_Tracker__Easy_Medium_
{
    internal class Student
    {
        private string name;
        private int id;
        private List<int> grades;

        public Student(string studentName, int studentId)
        {
            name = studentName;
            id = studentId;
            grades = new List<int>();
        }

        public void AddGrade(int grade)
        {
            grades.Add(grade);
        }

        public double CalculateAverage()
        {
            int total = 0;
            int count = 0;

            for (int i = 0; i < grades.Count; i++)
            {
                total = total + grades[i];
                count = count + 1;
            }

            if (count == 0)
            {
                return 0;
            }

            double average = (double)total / count;
            return average;
        }

        public void PrintStudentReport()
        {
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student ID: " + id);
            Console.WriteLine("Grades:");
            for (int i = 0; i < grades.Count; i++)
            {
                Console.WriteLine("- " + grades[i]);
            }
            Console.WriteLine("Average Grade: " + CalculateAverage());
            Console.WriteLine();
        }
    }

}
