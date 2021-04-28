using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Георгий Рыбко
//Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваш вес (в килограммах): ");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ваш рост (в метрах): ");
            double h = Convert.ToDouble(Console.ReadLine());

            double I = m / (h * h);    //вычисление ИМТ

            Console.WriteLine($"Индекс массы вашего тела составляет {I:F2}");


            Console.Write("Нажмите любую кравишу, чтобы продолжить");
            Console.ReadKey();
        }
    }
}
