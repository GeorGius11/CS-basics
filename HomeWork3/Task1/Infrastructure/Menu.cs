using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.View;
using Task1.Presenter;

namespace Task1.Infrastructure
{
    class Menu
    {
        public static void Start()
        {
            Calc calc = new Calc(new ConsoleView());

            Console.WriteLine("Press + to add, - to subtract, * to multiply or ESC to exit:");
            
            while (true)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Add: calc.Add(); break;
                    case ConsoleKey.Subtract:  calc.Subtract(); break;
                    case ConsoleKey.Multiply: calc.Multiply(); break;
                    case ConsoleKey.Escape: return;
                }
            }
        }
    }
}
