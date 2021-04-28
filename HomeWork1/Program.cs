using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Георгий Рыбко
//Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
//а) используя склеивание;
//б) используя форматированный вывод;
//в) используя вывод со знаком $.

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            
            Console.Write("Введите вашу фамилию: ");
            string surname = Console.ReadLine();
            
            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите ваш рост: ");
            double height = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Введите ваш вес: ");
            double weight = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Имя: " + name + " | Фамилия: " + surname + " | Возраст: " + age + " | Рост: " + height + " | Вес: " + weight);   //а)
            Console.WriteLine("Имя: {0} | Фамилия: {1} | Возраст: {2} | Рост: {3} | Вес: {4}", name, surname, age, height, weight);    //б)
            Console.WriteLine($"Имя: {name} | Фамилия: {surname} | Возраст: {age} | Рост: {height} | Вес: {weight}");   //в)


            Console.Write("Нажмите любую кравишу, чтобы продолжить");
            Console.ReadKey();
        }
    }
}
