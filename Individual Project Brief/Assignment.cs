using System;
using System.Collections.Generic;

namespace Individual_Project_Brief
{
    class Assignment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public double OralMark { get; set; }
        public double TotalMark { get; set; }
        public Course Course { get; set; }

        public Assignment() { }
        public Assignment(string title, string description, DateTime subDateTime, double oralMark, double totalMark)
        {
            Title = title;
            Description = description;
            SubDateTime = subDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
        }

        public void PrintAssignment()
        {
            Console.WriteLine($"{Title,-33} {Description,-25}  {SubDateTime.ToString("dd/MM/yyyy"),-15}  {OralMark,-10}  {TotalMark,-10}");
        }
    }
}
