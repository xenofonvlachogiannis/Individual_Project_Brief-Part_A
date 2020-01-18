using System;
using System.Collections.Generic;
using System.Linq;

namespace Individual_Project_Brief
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Fees { get; set; }

        public List<Course> CourseList { get; set; } = new List<Course>();
        public List<Assignment> AssignmentList { get; set; } = new List<Assignment>();

        public Student() { }
        public Student(string firstName, string lastName, DateTime dateOfBirth, double fees = 2500)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Fees = fees;
        }


        public void PrintStudent()
        {
            Console.WriteLine($"{FirstName,-15} {LastName,-20} {DateOfBirth.ToString("dd/MM/yyyy"),-15} {Fees,-5}");
        }

        public void PrintStudentsWithMoreCourses()
        {
            Console.Write($"{FirstName,-10} {LastName,-15}");
            Console.Write("  Courses: ");
            foreach (var item in CourseList)
            {
                Console.Write($"{item.Title,5}  ");
            }
            Console.WriteLine();
        }
        
        public void PrintAssignmentPerStudent()
        {
            if (CourseList.Count > 1)
            {
                Console.WriteLine($"{FirstName} {LastName}");

                foreach (var item in CourseList)
                {
                    Console.WriteLine($"\t   { item.Title}");

                    foreach (var assignment in item.AssignmentsList)
                    {
                        Console.WriteLine($"\t\t { assignment.Title}");

                    }
                }
            }
                        
        }
    }
}
