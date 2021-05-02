using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

//Рыбко Георгий
//5. а) Написать программу, которая запрашивает массу и рост человека,
//вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
//б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.


namespace Task5
{
    class Program
    {
        static string BMIstatus(double m, double h)
        {
            double I = m / (h * h);

            if (I >= 18.5 && I <= 24.9)
                return "Ваш ИМТ соотвествует нормам";
            else if (I < 18.5)
                return $"Масса вашего тела ниже нормы. Вам нужно набрать {18.5 * (h * h) - m} кг";
            else
                return $"Масса вашего тела выше нормы. Вам нужно сбросить {m - 24.9 * (h * h)} кг";
        }


        static void Main(string[] args)
        {
            Console.Write("Введите ваш вес (в килограммах): ");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ваш рост (в метрах): ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(BMIstatus(m, h));

            Lib.Pause();

        }
    }
}
