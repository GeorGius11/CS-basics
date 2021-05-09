using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Presenter;

namespace Task3.Infrastructure
{
    class Menu
    {
        public void Start()
        {
            Calc calc = new Calc(new View.ConsoleView());

            Console.WriteLine("Choose the operation and press the corresponding button:" +
                " +, -, * or / (Press ESC to exit)\n");
            
            while(true)
            {
                switch(Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Add: calc.Add(); break;
                    case ConsoleKey.Subtract: calc.Subtract(); break;
                    case ConsoleKey.Multiply: calc.Multiply(); break;
                    case ConsoleKey.Divide: calc.Divide(); break;
                    case ConsoleKey.Escape: return;
                }
            }
        }
    }
}
