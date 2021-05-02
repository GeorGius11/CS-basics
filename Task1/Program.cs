using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

//Рыбко Георгий
//1. Написать метод, возвращающий минимальное из трёх чисел.


namespace HomeWork_2
{
    class Program
    {
        static double Min(double a, double b, double c)
        {
            if (a < b && a < c)
                return a;
            else
            {
                if (b < c)
                    return b;
                else
                    return c;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input 3 numbers (separeted with space):");
            
            double[] n = Lib.InputDoubleNums(Console.ReadLine());
            
            Console.WriteLine("The smallest number is " + Min(n[0], n[1], n[2]));

            Lib.Pause();
        }
    }
}
