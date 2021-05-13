using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Infrastructure
{
    public struct student
    {
        string name;
        string surname;
        int[] marks;

        public student(string name, string surname, int m1, int m2, int m3)
        {
            this.name = name;
            this.surname = surname;
            marks = new int[] { m1, m2, m3 };
        }

        public double avg
        {
            get { return (marks[0] + marks[1] + marks[2]) / 3f; }
        }

        public override string ToString() => $"{name} {surname} {marks[0]} {marks[1]} {marks[2]}";

    }
}
