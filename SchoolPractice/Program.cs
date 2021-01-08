using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student michael = new Student();

            michael.Name = "Michael";
            michael.StudentId = 80083;
            michael.NumberOfCredits = 1;
            michael.Gpa = 4.0;

            //Console.WriteLine($"{michael.Name} ({michael.StudentId})");
            //Console.WriteLine($"Credits: {michael.NumberOfCredits} GPA: {michael.Gpa}");

            // Generate new course
            Course math = new Course();
            math.Id = 202;
            math.Name = "Geometry";
            math.Length = 17;
            math.NumCredits = 4;
            math.Roster = new List<Student>();

            math.Roster.Add(michael);
            math.Roster.Add(new Student("Balto", 451, 1, 3.50));
            math.Roster.Add(new Student("Shaniqua", 134, 2, 2.80));


            // Print info about Course
            Console.WriteLine($"{math.Name} ({math.Id})");
            Console.WriteLine("Roster:");

            foreach (Student student in math.Roster)
            {
                Console.WriteLine(student.Name);
            }

            Course history = new Course();
            history.Id = 205;
            history.Name = "Intro to World History";
            history.Length = 18;
            history.NumCredits = 6.0;

            history.AddStudent(new Student("Randy", 142, 3, 3.7));
            history.AddStudent(new Student("Linda", 174, 2, 2.9));
        }
    }
}
