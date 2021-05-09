using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Lib
    {
        public static int Gcd(int x, int y)
        {
            if (x == 0)
                return y;
            return Gcd(y % x, x);
        }
    }
}
