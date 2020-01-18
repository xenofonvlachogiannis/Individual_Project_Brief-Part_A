using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Brief
{
    class FrontEnd
    {
        SyntheticData sd = new SyntheticData();

        public void AddAssignment()
        {
            DateTime date;
            double mark;
            Assignment a = new Assignment();
            Console.WriteLine("Give title of Assignment: ");
            a.Title = Console.ReadLine();
            Console.WriteLine("Give description of Assignment: ");
            a.Description = Console.ReadLine();
            Console.WriteLine("Give submission date of Assignment (y/m/d): ");
            while (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("Wrong input! Give again date of submission (y/m/d)");
            }
            a.SubDateTime = date;
            Console.WriteLine("Give oral mark of Assignment: ");
            while (!Double.TryParse(Console.ReadLine(), out mark))
            {
                Console.WriteLine("Wrong input! Give again oral mark");
            }
            a.OralMark = mark;
            Console.WriteLine("Give total mark of Assignment: ");
            while (!Double.TryParse(Console.ReadLine(), out mark))
            {
                Console.WriteLine("Wrong input! Give again total mark");
            }
            a.TotalMark = mark;
            sd.AssignmentsList.Add(a);
        }

        public void AddCourse()
        {
            DateTime date;
            Course c = new Course();
            Console.Write("Give title of Course: ");
            c.Title = Console.ReadLine();
            Console.Write("Give stream of Course: ");
            c.Stream = Console.ReadLine();
            Console.Write("Give type of Course: ");
            c.Type = Console.ReadLine();
            Console.Write("Give Start Date of Course (y/m/d): ");
            while (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("Wrong input! Give again start date of course (y/m/d)");
            }
            c.StartDate = date;
            Console.Write("Give End Date of Course (y/m/d): ");
            while (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("Wrong input! Give again end date of course (y/m/d)");
            }
            c.EndDate = date;
            sd.CoursesList.Add(c);
        }

        public void AddStudent()
        {
            DateTime date;
            double fee;
            Student s = new Student();
            Console.Write("Enter first name of student: ");
            s.FirstName = Console.ReadLine();
            Console.Write("Enter last name of student: ");
            s.LastName = Console.ReadLine();
            Console.Write("Enter date of birth (y/m/d): ");
            while (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("Wrong input! Give again date of birth (y/m/d)");
            }
            s.DateOfBirth = date;
            Console.Write("Enter fees: ");
            while (!Double.TryParse(Console.ReadLine(), out fee))
            {
                Console.WriteLine("Wrong input! Give again fees");
            }
            s.Fees = fee;
            sd.StudentList.Add(s);
        }

        public void AddTrainer()
        {
            Trainer t = new Trainer();
            Console.Write("Give name of trainer: ");
            t.FirstName = Console.ReadLine();
            Console.Write("Give lastname of trainer: ");
            t.LastName = Console.ReadLine();
            Console.Write("Give subject of trainer: ");
            t.Subject = Console.ReadLine();
            sd.TrainersList.Add(t);
        }

        public void AddManyStudents()
        {
            string choice;
            do
            {
                AddStudent();
                Console.WriteLine("If you want to add more type anything or \"exit\" for exit");
                choice = Console.ReadLine().ToLower();
            } while (choice != "exit");
        }

        public void AddManyCourses()
        {
            string choice;
            do
            {
                AddCourse();
                Console.WriteLine("If you want to add more type anything or \"exit\" for exit");
                choice = Console.ReadLine().ToLower();
            } while (choice != "exit");
        }

        public void AddManyTrainers()
        {
            string choice;
            do
            {
                AddTrainer();
                Console.WriteLine("If you want to add more type anything or \"exit\" for exit");
                choice = Console.ReadLine().ToLower();
            } while (choice != "exit");
        }

        public void AddManyAssignmets()
        {
            string choice;
            do
            {
                AddAssignment();
                Console.WriteLine("If you want to add more type anything or \"exit\" for exit");
                choice = Console.ReadLine().ToLower();
            } while (choice != "exit");
        }

        public void PrintListCourse()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"                        --COURSES INFO--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"---------------------------------------------------------------------");
            Console.WriteLine($"  Title          Stream         Type       Start Date      End Date");
            Console.WriteLine($"---------------------------------------------------------------------");
            foreach (var item in sd.CoursesList)
            {
                item.PrintCourse();
            }
            Console.WriteLine();
        }

        public void PrintListStudent()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"                    --STUDENTS INFO--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"First Name      Last Name           Date of Birth    Fees");
            Console.WriteLine("-----------------------------------------------------------");
            foreach (var item in sd.StudentList)
            {
                item.PrintStudent();
            }
            Console.WriteLine();
        }

        public void PrintListOfTrainers()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"        --TRAINERS INFO--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"----------------------------------------");
            Console.WriteLine($"First Name      Last Name       Subject");
            Console.WriteLine($"----------------------------------------");
            foreach (var item in sd.TrainersList)
            {
                item.PrintTrainer();
            }
            Console.WriteLine();
        }

        public void PrintListOfAssignment()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"                                    --ASSIGNMENTS INFO--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"------------------------------------------------------------------------------------------------");
            Console.WriteLine($"        Title                      Description                Sub Date    Oral Mark   Total Mark");
            Console.WriteLine($"------------------------------------------------------------------------------------------------");
            foreach (var item in sd.AssignmentsList)
            {
                item.PrintAssignment();
            }
            Console.WriteLine();
        }

        public void PrintListStudentsPerCourse()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"     --STUDENTS PER COURSE--");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in sd.StudentsPerCourseList)
            {
                item.Output();
            }
            Console.WriteLine();
        }

        public void PrintListTrainersPerCourse()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"   --TRAINERS PER COURSE--");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in sd.TrainersPerCourseList)
            {
                item.Output();
            }
            Console.WriteLine();
        }

        public void PrintListAssignmentsPerCourse()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"             --ASSIGNMENT PER COURSE--");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in sd.AssignmentsPerCourseList)
            {
                item.Output();
            }
            Console.WriteLine();
        }

        public void PrintStudentsWithMoreCourses()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("        --STUDENT WITH MORE COURSE--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
            foreach (var item in sd.StudentList)
            {
                if (item.CourseList.Count > 1)
                {
                    item.PrintStudentsWithMoreCourses();

                }
            }
        }

        public void PrinAssignmentPerStudent()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("        --ASSIGNMENT PER STUDENT--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------");
            foreach (var item in sd.StudentList)
            {
                item.PrintAssignmentPerStudent();
            }
            Console.WriteLine();
            Console.WriteLine("________________________________________________");
            Console.WriteLine(); 
        }

        public void PrinStudentWithSubmit()
        {
            DateTime date;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     --STUDENT WHO NEED TO SUBMIT--");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Input date to check for submit (y/m/d)");

            while (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("Wrong input!!, Give again date for submit (y/m/d)");
            }

            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                date.AddDays(-6);
            }
            else if (date.DayOfWeek == DayOfWeek.Saturday)
            {
                date.AddDays(-5);
            }
            else if (date.DayOfWeek == DayOfWeek.Friday)
            {
                date.AddDays(-4);
            }
            else if (date.DayOfWeek == DayOfWeek.Thursday)
            {
                date.AddDays(-3);
            }
            else if (date.DayOfWeek == DayOfWeek.Wednesday)
            {
                date.AddDays(-2);
            }
            else if (date.DayOfWeek == DayOfWeek.Tuesday)
            {
                date.AddDays(-1);
            }
            Console.WriteLine();
            foreach (var item in sd.StudentList)
            {

                foreach (var assignment in item.AssignmentList)
                {
                    if (assignment.SubDateTime >= date && assignment.SubDateTime <= date.AddDays(4))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"___Student: {item.FirstName} {item.LastName}___");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Assignement: {assignment.Title}");
                        Console.WriteLine($"Submission Date: {assignment.SubDateTime.ToString("dd/MM/yyyy")}");
                        Console.WriteLine();
                    }

                }
            }
        }
    }
}
