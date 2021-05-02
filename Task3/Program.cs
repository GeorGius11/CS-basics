using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

//Рыбко Георгий
//3. С клавиатуры вводятся числа, пока не будет введен 0.
//Подсчитать сумму всех нечетных положительных чисел.


namespace Task3
{
    class Program
    {
        //Метод, проверяющий число на нечётность (возвращает true, если число нечётное).
        static bool IsOdd(int i)
        {
            if (i % 2 == 0)
                return false;
            else
                return true;
        }

        static void Main(string[] args)
        {
            int i, sum = 0;
            
            Console.WriteLine("Input numbers, separating them with ENTER. Input 0 to stop.");
            i = Convert.ToInt32(Console.ReadLine());
            
            while (i != 0)
            {
                if(i > 0 && IsOdd(i))
                    sum += i;
                i = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"The sum of odd positive elements is {sum}");
            
            Lib.Pause();
        }
    }
}
