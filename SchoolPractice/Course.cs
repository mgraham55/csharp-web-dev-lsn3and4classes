using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        //Name: string
        //Length: int(numweeks)
        //Roster: list< >
        //NumCredits: double

        public int Id { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public List<Student> Roster { get; set; }
        public double NumCredits { get; set; }
        public Course()
        {
        }

        public void AddStudent(Student student)
        {
            if (this.Roster == null)
            {
                this.Roster = new List<Student>();
            }
            
            this.Roster.Add(student);
        }
    }
}
