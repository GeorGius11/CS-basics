using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_3.Views
{
    public abstract class View
    {
        public abstract void Print(string msg);

        public abstract void PrintLine(string msg);

        public abstract string Input();
    }

    public class ConsoleView : View
    {
        public override void Print(string msg) => Console.Write(msg);

        public override void PrintLine(string msg) => Console.WriteLine(msg);

        public override string Input() => Console.ReadLine();
    }
}
