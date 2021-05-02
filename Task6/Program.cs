using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

//Рыбко Георгий
//6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
//«Хорошим» называется число, которое делится на сумму своих цифр.
//Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

namespace Task6
{

    class Program
    {
        //Метод, который высчитывает сумму цифр переданноого числа.
        static uint SumOfDigits(uint i)
        {
            uint sum = 0;
            while (i != 0)
            {
                sum += i % 10;
                i /= 10;
            }
            return sum;
        }

        //Метод, который проверяет, является ли число "хорошим".
        static bool IsGoodNum(uint num)
        {
            if (num % SumOfDigits(num) == 0)
                return true;
            else return false;
        }

        //Метод, который определят количество "хороших" чисел в указанном интервале.
        static uint GoodNums(uint first, uint last)
        {
            uint q = 0;
            for (uint i = first; i < last; i++)
            {
                if (IsGoodNum(i) == true)
                    q++;
            }
            return q;
        }

        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            
            Console.WriteLine("The quantity of \"good\" numbers in the interval [1, 1000000000] is {0}",
                GoodNums(1, 1000000000));
            
            TimeSpan interval = DateTime.Now - start;
            
            Console.WriteLine("Execution time: " + interval.ToString(@"hh\:mm\:ss"));

            Lib.Pause();
        }
    }
}
