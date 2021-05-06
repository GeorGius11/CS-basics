using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Георгий Рыбко
//2. а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
//Требуется подсчитать сумму всех нечётных положительных чисел.
//Сами числа и сумму вывести на экран, используя tryParse.

namespace Task2
{

    class Program
    {
        static bool IsOdd(int num)
        {
            if (num % 2 != 0)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            int num, s = 0;
            Console.WriteLine("Input numpers (separated with 0). Input 0 to stop");
            do
            {
                int.TryParse(Console.ReadLine(), out num);
                if (num > 0 && IsOdd(num))
                    s += num;
            } while (num != 0);
            
            Console.WriteLine($"The sum of positive odd numbers is {s}");
            
            Console.ReadKey();
        }
    }
}
