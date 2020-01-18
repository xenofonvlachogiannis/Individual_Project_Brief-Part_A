using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Brief
{
    class StudentPerCourse
    {
        public Course Course { get; set; }
       
        public StudentPerCourse(Course course, List<Student> studentsList)
        {
            Course = course;

            course.StudentsList = studentsList;

            foreach (var item in studentsList)
            {
                item.CourseList.Add(course);
            }
        }

        public void Output()
        {
            
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Course Title: {Course.Title}");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            foreach (var item in Course.StudentsList)
            {
                Console.WriteLine($"{item.FirstName,-10} {item.LastName}");
            }
            Console.WriteLine();
        }

    
    }


}
