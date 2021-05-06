using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Infrastructure;
using Task1.Models;
using Task1.View;

namespace Task1.Presenter
{
    class Calc
    {
        Model model;
        ConsoleView View;

        public Calc(ConsoleView view)
        {
            this.View = view;
            model = new Model();
        }

        public void Add()
        {
            View.Print("\nInput complex number x:");
            Complex x = View.GetNum();
            View.Print("\nInput complex number y:");
            Complex y = View.GetNum();

            View.Print($"(\n{x.ToString()}) + ({y.ToString()}) = {model.Sum(x, y).ToString()}");
        }

        public void Subtract()
        {
            View.Print("\nInput complex number x:");
            Complex x = View.GetNum();
            View.Print("\nInput complex number y:");
            Complex y = View.GetNum();

            View.Print($"(\n{x.ToString()}) - ({y.ToString()}) = {model.Difference(x, y).ToString()}");
        }

        public void Multiply()
        {
            View.Print("\nInput complex number x:");
            Complex x = View.GetNum();
            View.Print("\nInput complex number y:");
            Complex y = View.GetNum();

            View.Print($"(\n{x.ToString()}) * ({y.ToString()}) = {model.Multiplication(x, y).ToString()}");
        }
    }
}
