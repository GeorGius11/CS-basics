using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_3.Presenter;
using Task1_3.Views;

namespace Task1_3.Infrastructure
{
    class Menu
    {
        public void Start()
        {
            ConsoleView view = new ConsoleView();
            Calc calc = new Calc(view);
            calc.ShowMenu();
            while (true)
            {
                switch(Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1: calc.ValidateLogin(); break;
                    case ConsoleKey.D2: calc.WordsNotLongerThanNum(); break;
                    case ConsoleKey.D3: calc.DeleteWordsEndingWithChar(); break;
                    case ConsoleKey.D4: calc.LongestWord(); break;
                    case ConsoleKey.D5: calc.LongestWords(); break;
                    case ConsoleKey.D6: calc.FreqArr(); break;
                    case ConsoleKey.D7: calc.IsReshuffle(); break;
                    case ConsoleKey.D8: calc.ShowMenu(); break;
                    case ConsoleKey.Escape: return;
                }
            }
        }
    }
}
