using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Infrastructure
{
    class Complex
    {
        private double re;
        private double im;

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public double Re
        {
            get { return re; }
            set { this.re = value; }
        }

        public double Im
        {
            get { return im; }
            set { this.im = value; }
        }

        public override string ToString()
        {
            if(im == (-1))
                return $"{re} - i";
            else if (im == 1)
                return $"{re} + i";
            else if (im < 0)
                return $"{re} - {im*(-1)}i";
            else
                return $"{re} + {im}i";
        }
    }
}
