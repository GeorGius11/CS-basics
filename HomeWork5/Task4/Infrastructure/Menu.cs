using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.Presenter;
using Task4.Views;

namespace Task4.Infrastructure
{
    class Menu
    {
        public void Start()
        {
            Calc calc = new Calc(new ConsoleView());
            
            while (true)
            {
                calc.FillStudents();
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    return;
            }
        }
    }
}
