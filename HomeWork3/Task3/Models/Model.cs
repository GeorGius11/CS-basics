using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Task3.Infrastructure;

namespace Task3.Models
{
    class Model
    {

        public Fraction Short(Fraction x)
        {
            int gcd = Lib.Gcd(x.Num, x.Den);
            return new Fraction(x.Num / gcd, x.Den / gcd);
        }

        public Fraction Add(Fraction x, Fraction y)
        {
            int lcm = (x.Den * y.Den) / Lib.Gcd(x.Den, y.Den);
            int Num = x.Num * (lcm / x.Den) + y.Num * (lcm / y.Den);
            Fraction fraction = new Fraction(Num, lcm);
            return Short(fraction);       
        }

        public Fraction Subtract(Fraction x, Fraction y)
        {
            int lcm = (x.Den * y.Den) / Lib.Gcd(x.Den, y.Den);
            int Num = x.Num * (lcm / x.Den) - y.Num * (lcm / y.Den);
            Fraction fraction = new Fraction(Num, lcm);
            return Short(fraction);
        }

        public Fraction Multiply(Fraction x, Fraction y)
        {
            Fraction fraction = new Fraction(x.Num * y.Num, x.Den * y.Den);
            return Short(fraction);
        }

        public Fraction Divide(Fraction x, Fraction y)
        {
            Fraction fraction = new Fraction(x.Num * y.Den, x.Den * y.Num);
            return Short(fraction);
        }
    }
}
