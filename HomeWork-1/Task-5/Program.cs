﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Георгий Рыбко
//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) *Сделать задание, только вывод организовать в центре экрана.
//в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x, int y).

namespace Task5
{
    class Program
    {
        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        static void Main(string[] args)
        {
            string name = "Георгий";
            string surname = "Рыбко";
            string city = "Одесса";

            string info = "Имя: " + name + " | Фамилия: " + surname + " | Город: " + city;

            Print(info, 35, 13);


            Console.Write("Нажмите любую кравишу, чтобы продолжить");
            Console.ReadKey();
        }
    }
}
