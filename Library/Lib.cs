using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Lib
    {


        //Метод, который принимает строчку с дробными числами и разделителем в виде клавиши пробел, а возвращает массив из чисел.
        public static double[] InputDoubleNums(string given)
        {
            string[] strNums = given.Split(' ');
            double[] nums = new double[strNums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToDouble(strNums[i]);
            }
            return nums;
        }

        //Метод, который принимает строчку с целыми числами и разделителем в виде клавиши пробел, а возвращает массив из чисел.
        public static int[] InputIntNums(string given)
        {
            string[] strNums = given.Split(' ');
            int[] nums = new int[strNums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(strNums[i]);
            }
            return nums;
        }

        //Метод "Пауза".
        public static void Pause()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}