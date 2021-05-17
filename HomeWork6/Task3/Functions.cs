using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Functions
    {
        public List<Student> ReadStudents(string path)
        {
            List <Student> students = new List<Student>();
            StreamReader sr = new StreamReader(path);
            while(!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split(';');
                students.Add(new Student(s[0], s[1], s[2], int.Parse(s[3]), int.Parse(s[4]), int.Parse(s[5]), s[6]));
            }
            sr.Close();
            return students;
        }

        public void PrintStudent(List<Student> students)
        {
            foreach(Student student in students)
            {
                Console.WriteLine(student.Info());
            }
        }

        public int NumOfMasters(List<Student> students)
        {
            int n = 0;
            foreach (var item in students)
            {
                if (item.Course == 5 || item.Course == 6)
                    n++;
            }
            return n;
        }

        public Dictionary<int, int> NumOf18_20OnCourse(List<Student> students)
        {
            
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i = 1; i <= 6; i++)
            { 
                int n = 0;
                foreach (var item in students)
                {
                    if (item.Age >= 18 && item.Age <= 20 && item.Course == i)
                        n++;
                }
                if (n != 0)
                    dict.Add(i, n);
            }

            return dict;
        }

        public List<Student> SortByAge(List<Student> students)
        {
            List<Student> students1 = new List<Student>();

            for (int i = 0; i < students.Count; i++)
            {
                int min = students[i].Age;
                for (int j = 0; j < students.Count; j++)
                {
                    if (students[j].Age < min)
                        min = students[j].Age;
                }
                for (int j = 0; j < students.Count; j++)
                {
                    if (students[j].Age == min)
                    {
                        students1.Add(students[j]);
                        students.Remove(students[j]);
                        i--;
                        break;
                    }
                }
            }

            return students1;
        }

    }
}
