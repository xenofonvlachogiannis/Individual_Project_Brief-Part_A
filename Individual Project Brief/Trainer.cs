using System;
using System.Collections.Generic;

namespace Individual_Project_Brief
{
    class Trainer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public Course Course { get; set; }

        public Trainer() { }
        public Trainer(string firstName, string lastname, string subject)
        {
            FirstName = firstName;
            LastName = lastname;
            Subject = subject;
        }

        

        public void PrintTrainer()
        {
            Console.WriteLine($"{FirstName,-15}  {LastName,-15}  {Subject,-10}");
        }
    }
}
