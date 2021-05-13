using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.Infrastructure;

namespace Task4.Models
{
    class Model
    {

        public double MinAvg(List<student> students)
        {
            double MinAvg = students[0].avg;
            foreach (var item in students)
            {
                if (item.avg < MinAvg)
                    MinAvg = item.avg;
            }
            return MinAvg;
        }

        public List<student> ThreeWorst(List<student> Students)
        {
            List<student> students = new List<student>(Students);
            List<student> Worst = new List<student>();
            for (int i = 0; i < 3; i++)
            {
                double minAvg = MinAvg(students);
                for (int j = 0; j < students.Count; j++)
                {
                    if (students[j].avg == minAvg)
                    {
                        Worst.Add(students[j]);
                        //Console.WriteLine(students[j]);
                        students.Remove(students[j]);
                        j--;
                    }
                }
            }
            return Worst;
        }

        public List<student> FillStudents(string path)
        {
            string[] s = File.ReadAllLines(path);
            List<student> students = new List<student>();
            foreach (var item in s)
            {
                string[] spl = item.Split(' ');
                student st = new student(spl[0], spl[1], int.Parse(spl[2]), int.Parse(spl[3]), int.Parse(spl[4]));
                students.Add(st);
            }
            return students;
        }
    }
}
