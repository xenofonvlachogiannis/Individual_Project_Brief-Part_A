using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Brief
{
   class SyntheticData
    {
        public List<Student> StudentList { get; set; }

        public List<Assignment> AssignmentsList { get; set; }

        public List<Course> CoursesList { get; set; }

        public List<Trainer> TrainersList { get; set; }

        public List<StudentPerCourse> StudentsPerCourseList { get; set; }

        public List<TrainerPerCourse> TrainersPerCourseList { get; set; }

        public List<AssignmentPerCourse> AssignmentsPerCourseList { get; set; }
  
        public SyntheticData()
        {
            Student s1 = new Student("Xenofon", "Vlachogiannis", new DateTime(1989, 08, 01), 2500);
            Student s2 = new Student("Nikolaos", "Sentis", new DateTime(1990, 11, 10), 2500);
            Student s3 = new Student("Panagiotis", "Rizos", new DateTime(1993, 05, 13), 2500);
            Student s4 = new Student("Karolos", "Koniewicz", new DateTime(1993, 03, 22), 2500);
            Student s5 = new Student("Zacharias", "Drimiskianakis", new DateTime(1992, 12, 03), 2500);
            Student s6 = new Student("Alexandros", "Perikleous", new DateTime(1992, 01, 10), 2500);
            Student s7 = new Student("Eleni", "Parisi", new DateTime(1989, 11, 20), 2500);
            Student s8 = new Student("Eystathios", "Kanellis", new DateTime(1986, 09, 19), 2500);
            Student s9 = new Student("Giorgos", "Poulakos", new DateTime(1988, 04, 04), 2500);
            Student s10 = new Student("Thanos", "Katsakis", new DateTime(1991, 07, 29), 2500);

            StudentList = new List<Student>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10 };

            List<Student> studentList1 = new List<Student> { s1, s2 };
            List<Student> studentList2 = new List<Student> { s3, s4 };
            List<Student> studentList3 = new List<Student> { s5, s6, s7, s8, s9 };
            List<Student> studentList4 = new List<Student> { s1, s4, s7, s10 };

            Course c1 = new Course("CB7", "Full time", "C#", new DateTime(2019, 12, 11), new DateTime(2020, 04, 02));
            Course c2 = new Course("CB8", "Full time", "Java", new DateTime(2019, 12, 10), new DateTime(2020, 04, 03));
            Course c3 = new Course("CB9", "Part time", "Sql", new DateTime(2019, 12, 07), new DateTime(2020, 07, 05));
            Course c4 = new Course("CB10", "Part time", "Html", new DateTime(2019, 12, 09), new DateTime(2020, 07, 06));

            CoursesList = new List<Course>() { c1, c2, c3, c4 };
        
            Trainer t1 = new Trainer("Hector", "Gkatsos", "C#");
            Trainer t2 = new Trainer("Konstantinos", "Zitis", "Java");
            Trainer t3 = new Trainer("Panos", "Bozas", "HTML");
            Trainer t4 = new Trainer("Manolis", "Kapsis", "HTML");
            Trainer t5 = new Trainer("Nikolaos", "Manakis", "SQL");

            TrainersList = new List<Trainer>() { t1, t2, t3, t4, t5 };

            List<Trainer> TrainersList1 = new List<Trainer>() { t1, t2 };
            List<Trainer> TrainersList2 = new List<Trainer>() { t3, t4 };
            List<Trainer> TrainersList3 = new List<Trainer>() { t2, t5 };
            List<Trainer> TrainersList4 = new List<Trainer>() { t1, t3 };

            Assignment a1 = new Assignment("Design a Private School", "Individal Project", new DateTime(2020, 01, 20), 15, 18);
            Assignment a2 = new Assignment("Design a Company", "Individal Project", new DateTime(2020, 03, 19), 12, 15);
            Assignment a3 = new Assignment("Create an e-shop", "Group Project", new DateTime(2020, 05, 05), 18, 19);
            Assignment a4 = new Assignment("Create Program for Zara", "Group Project", new DateTime(2020, 02, 04), 13, 18);
            Assignment a5 = new Assignment("Design a Travel App", "Individal Project", new DateTime(2020, 01, 16), 15, 18);
            Assignment a6 = new Assignment("Design an App for Android", "Individal Project", new DateTime(2020, 03, 19), 12, 15);
            Assignment a7 = new Assignment("Create Program for Plaisio", "Group Project", new DateTime(2020, 03, 02), 17, 19);
            Assignment a8 = new Assignment("Create Final Project", "Group Project", new DateTime(2020, 02, 04), 13, 18);

            AssignmentsList = new List<Assignment>() { a1, a2, a3, a4, a5, a6, a7, a8 };

            List<Assignment> assignmentList1 = new List<Assignment>() { a1, a2 };
            List<Assignment> assignmentList2 = new List<Assignment>() { a3, a4 };
            List<Assignment> assignmentList3 = new List<Assignment>() { a5, a6 };
            List<Assignment> assignmentList4 = new List<Assignment>() { a7, a8 };

            StudentPerCourse spc1 = new StudentPerCourse(c1, studentList1);
            StudentPerCourse spc2 = new StudentPerCourse(c2, studentList2);
            StudentPerCourse spc3 = new StudentPerCourse(c3, studentList3);
            StudentPerCourse spc4 = new StudentPerCourse(c4, studentList4);

            StudentsPerCourseList = new List<StudentPerCourse>() { spc1, spc2, spc3, spc4 };

            TrainerPerCourse tpc1 = new TrainerPerCourse(c1, TrainersList1);
            TrainerPerCourse tpc2 = new TrainerPerCourse(c2, TrainersList2);
            TrainerPerCourse tpc3 = new TrainerPerCourse(c3, TrainersList3);
            TrainerPerCourse tpc4 = new TrainerPerCourse(c4, TrainersList4);

            TrainersPerCourseList = new List<TrainerPerCourse>() { tpc1, tpc2, tpc3, tpc4 };

            AssignmentPerCourse apc1 = new AssignmentPerCourse(c1, assignmentList1);
            AssignmentPerCourse apc2 = new AssignmentPerCourse(c2, assignmentList2);
            AssignmentPerCourse apc3 = new AssignmentPerCourse(c3, assignmentList3);
            AssignmentPerCourse apc4 = new AssignmentPerCourse(c4, assignmentList4);

            AssignmentsPerCourseList = new List<AssignmentPerCourse>() { apc1, apc2, apc3, apc4 };
        }       
    }
}
