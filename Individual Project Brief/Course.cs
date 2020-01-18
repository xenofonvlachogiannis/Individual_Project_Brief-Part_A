using System;
using System.Collections.Generic;

namespace Individual_Project_Brief
{
    class Course
    {
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<Student> StudentsList { get; set; } = new List<Student>();
        public List<Trainer> TrainersList { get; set; } = new List<Trainer>();
        public List<Assignment> AssignmentsList { get; set; } = new List<Assignment>();

        public Course(){ }
        public Course(string title, string stream, string type, DateTime startDate, DateTime endDate)
        {
            Title = title;
            Stream = stream;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
            StudentsList = new List<Student>();
            TrainersList = new List<Trainer>();
            AssignmentsList = new List<Assignment>();
        }

        public void PrintCourse()
        {
            Console.WriteLine($"{Title,-15} {Stream,-15} {Type,-10} {StartDate.ToString("dd/MM/yyyy"),-15} {EndDate.ToString("dd/MM/yyyy"),-15}");
        }

    }
}
