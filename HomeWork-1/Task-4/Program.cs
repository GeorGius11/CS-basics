using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Георгий Рыбко
//Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;
//б) *без использования третьей переменной.

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Замена с третьей переменной

            Console.Write("Введите значение переменной a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение переменной b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Взаимозаменённые значения с помощью третьей переменной: a = {a}, b = {b}\n");

            #endregion

            #region Замена без третьей переменной

            Console.Write("Введите значение переменной a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение переменной b: ");
            b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Взаимозаменённые значения без помощи третьей переменной: a = {a}, b = {b}");

            #endregion


            Console.Write("Нажмите любую кравишу, чтобы продолжить");
            Console.ReadKey();
        }
    }
}
