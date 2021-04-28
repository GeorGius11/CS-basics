using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Георгий Рыбко
//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2, y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
//б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

namespace Task3
{
    class Program
    {
        static double Length(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки x (разделив их клавишей ENTER): ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты точки y (разделив их клавишей ENTER): ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Расстояние между точками x и y составляет {Length(x1, x2, y1, y2)}");


            Console.Write("Нажмите любую кравишу, чтобы продолжить");
            Console.ReadKey();
        }
    }
}
