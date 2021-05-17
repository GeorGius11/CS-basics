using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public struct Student
    {
        public string Name;
        public string Surname;
        public string University;
        public int Age;
        public int Course;
        public int Group;
        public string City;

        public Student(string Name, string Surname, string University, int Age, int Course, int Group, string City)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.University = University;
            this.Age = Age;
            this.Course = Course;
            this.Group = Group;
            this.City = City;
        }

        public string Info() => $"Name: {Name} | Surname:{Surname} | University: {University} | Age: {Age} | Course: {Course} | Group: {Group} | City: {City}";
    }
}
