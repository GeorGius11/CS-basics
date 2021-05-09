using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Infrastructure;

namespace Task1.Models
{
    class Model
    {
        public Complex Sum(Complex x, Complex y) => new Complex(x.Re + y.Re, x.Im + y.Im);
        
        public Complex Difference(Complex x, Complex y) => new Complex(x.Re - y.Re, x.Im - y.Im);

        public Complex Multiplication(Complex x, Complex y)
        {
            double prod1 = x.Re * y.Re;
            double prod2 = x.Im * y.Im;
            double prod3 = (x.Re + x.Im) * (y.Re + y.Im);

            double real = prod1 - prod2;

            double imag = prod3 - (prod1 + prod2);

            return new Complex(real, imag);
        }
    }
}
