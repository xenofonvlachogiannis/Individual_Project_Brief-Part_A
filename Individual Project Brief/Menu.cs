using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Brief
{
    static class Menu
    {
        public static void RunMenu()
        {
            FrontEnd fe = new FrontEnd();
            string choice;
            int inchoice,temp;

            do
            {
                Console.WriteLine("Welcome to Private School Manager");
                Console.WriteLine("1.   For Input");
                Console.WriteLine("2.   For Synthetic Data");
                Console.WriteLine("3.   Exit");
                Console.WriteLine();
                Console.Write("Choose one of the above: ");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("1.   Input Course");
                    Console.WriteLine("2.   Input Student");
                    Console.WriteLine("3.   Input Trainer");
                    Console.WriteLine("4.   Input Assignment");
                    Console.WriteLine();
                    Console.Write("Choose one of the above: ");
                    Console.WriteLine();
                    while (!Int32.TryParse(Console.ReadLine(), out temp))
                    {
                        Console.WriteLine("-- Wrong input --");
                    }
                    inchoice = temp;

                    switch (inchoice)
                    {
                        case 1:
                            fe.AddManyCourses();
                            break;
                        case 2:
                            fe.AddManyStudents();
                            break;
                        case 3:
                            fe.AddManyTrainers();
                            break;
                        case 4:
                            fe.AddManyAssignmets();
                            break;
                        default:
                            Console.WriteLine("Wrong Input");
                            break;
                    }
                }
                else if (choice == "2")
                {
                    fe.PrintListCourse();
                    fe.PrintListStudent();
                    fe.PrintListOfTrainers();
                    fe.PrintListOfAssignment();
                    fe.PrintListStudentsPerCourse();
                    fe.PrintListTrainersPerCourse();
                    fe.PrintListAssignmentsPerCourse();
                    fe.PrintStudentsWithMoreCourses();
                    fe.PrinAssignmentPerStudent();
                    fe.PrinStudentWithSubmit();

                }
                else if (choice != "3")
                {
                    Console.WriteLine("-- Wrong input --");
                    Console.WriteLine();
                }

            } while (choice != "3");
        }
    }
}
