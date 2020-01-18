using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Brief
{
    class AssignmentPerCourse
    {
        public Course Course { get; set; }

        public AssignmentPerCourse(Course course,List<Assignment> assignmentList)
        {
            Course = course;
            course.AssignmentsList = assignmentList;
            
            // Εδώ γινεται κατευθειαν γεμισμα της λιστας assignment του student.
            foreach (var item in course.StudentsList)
            {
                item.AssignmentList.AddRange(assignmentList);
            }

            foreach (var item in assignmentList)
            {
                item.Course=course;
            }

        }

        public void Output()
        {
            Console.WriteLine($"                Course Title: {Course.Title}");
            Console.WriteLine("---------------------------------------------------");
            foreach (var item in Course.AssignmentsList)
            {
                Console.WriteLine($"Assignment Title: {item.Title,-25}");
            }
            Console.WriteLine();
        }

    }
}
