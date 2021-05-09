using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Infrastructure;

namespace Task1.View
{
    class ConsoleView
    {
        public void Print(string s) => Console.WriteLine(s);

        public Complex GetNum()
        {
            Console.Write("Re: --> ");
            Double.TryParse(Console.ReadLine(), out double re);
            Console.Write("Im: --> ");
            Double.TryParse(Console.ReadLine(), out double im);
            return new Complex(re, im);
        }

    }
}
