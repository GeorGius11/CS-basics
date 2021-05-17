using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    public delegate double Fun(double a, double x);
    class Functions
    {
        public void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine(" ---- A ------ X ------ Y ----  ");
            while (x <= b)
            {
                Console.WriteLine("| {0,7:0.0} | {1,7:0.0} | {2,7:0.0} |", a, x, F(a, x));
                x += 1;
            }
            Console.WriteLine(" ----------------------------- ");
        }
        public double MyFunc(double a, double x) => a * Math.Pow(x, 2);
        public double MyFunc2(double a, double x) => a * Math.Sin(x);
    }
}
