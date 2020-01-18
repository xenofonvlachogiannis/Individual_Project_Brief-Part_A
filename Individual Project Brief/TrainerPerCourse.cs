using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Brief
{
    class TrainerPerCourse
    {
        public Course Course { get; set; }

        public TrainerPerCourse (Course course, List<Trainer> trainerList)
        {
            Course = course;
            course.TrainersList = trainerList;
        }
        
        public void Output()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Course Title: {Course.Title}");
            Console.WriteLine("----------------------------");
            {
                foreach (var item in Course.TrainersList)
                {
                    Console.WriteLine($"{item.FirstName,-15} {item.LastName,-15}");
                }
            }
        }

    }
}
