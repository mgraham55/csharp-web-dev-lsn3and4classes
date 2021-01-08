using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        // Default Constructor option 1
        public Student() { }

        // Constructor option 2
        public Student(string name, int id, int credits, double gpa)
        {
            this.Name = name;
            this.StudentId = id;
            this.NumberOfCredits = credits;
            this.Gpa = gpa;
        }

        public void AddGrade(int numCredits, double grade)
        {

        }
    }
}
