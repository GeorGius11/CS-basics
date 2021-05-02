using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

//Рыбко Георгий
//7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
//б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.


namespace Task7
{
    class Program
    {
        static void Output(int a, int b)
        {
            if(a > b)
            {
                Console.WriteLine("First number must be smaller than second");
                return;
            }

            Console.Write(a + " ");

            if (a == b)
            {
                Console.WriteLine();
                return;
            }

            Output(a + 1, b);
        }

        static int SumBetweenNums(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("First number must be smaller than second");
                return 0;
            }
            else if (a == b)
                return a;

            return a + SumBetweenNums(a + 1, b);
        }

        static void Main(string[] args)
        {
            Console.Write("Input two numbers (separated with space), first number smaller than second: ");
            int[] nums = Lib.InputIntNums(Console.ReadLine());
            
            Output(nums[0], nums[1]);

            Console.WriteLine($"Sum: {SumBetweenNums(nums[0], nums[1])}");

            Lib.Pause();
        }
    }
}
