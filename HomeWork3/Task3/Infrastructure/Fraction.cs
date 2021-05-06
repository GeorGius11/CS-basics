using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Infrastructure
{
    class Fraction
    {
        private int num;
        private int den;

        public Fraction()
        {
            num = 1;
            den = 1;
        }

        public Fraction(int num, int den)
        {
            if (den == 0) 
                throw new ArgumentException("Denominator cannot be equal to 0");
            
            this.num = num;
            this.den = den;
        }

        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        public int Den
        {
            get { return den; }
            set 
            {
                if (value == 0) 
                    throw new ArgumentException("Denominator cannot be equal to 0");
                
                this.den = value; 
            }
        }

        public double GetDecimal
        {
            get { return num / den; }
        }

        public override string ToString() => ($"{num}/{den}");
    }
}
