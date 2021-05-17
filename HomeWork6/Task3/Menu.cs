using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Menu
    {
        public void Start()
        {
            Functions functions = new Functions();
            List<Student> students = functions.ReadStudents("student.csv");

            students = functions.SortByAge(students);

            functions.PrintStudent(students);

            Console.WriteLine($"Number of masters: {functions.NumOfMasters(students)}");

            Dictionary<int, int> dict = functions.NumOf18_20OnCourse(students);
            
            foreach (var item in dict)
                Console.WriteLine($"Course: {item.Key} | Num: {item.Value}");

            Console.ReadKey();
        }
    }
}
