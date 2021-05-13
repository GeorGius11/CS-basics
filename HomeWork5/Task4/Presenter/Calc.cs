using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.Infrastructure;
using Task4.Models;
using Task4.Views;

namespace Task4.Presenter
{
    class Calc
    {
        Model model;
        View view;
        public Calc(View view)
        {
            model = new Model();
            this.view = view;
        }

        public void FillStudents()
        {
            view.Print("Enter the path to the file:\n--> ");
            string path = view.Input(); 
            if (File.Exists(path))
            {
                List<student> students = model.FillStudents(@path);
                view.PrintLine("\nContent of the file:\n");
                foreach (var item in students)
                    view.PrintLine(item.ToString());

                view.PrintLine("\n=========================\n");
                view.PrintLine("The worst students:\n");
                List<student> Worst = model.ThreeWorst(students);
                foreach (var item in Worst)
                    view.PrintLine(item.ToString());
                view.PrintLine("");
            }
            else
                view.PrintLine("File does not exist\n");
        }
    }
}
