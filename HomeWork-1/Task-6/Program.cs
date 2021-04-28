using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Георгий Рыбко
//*Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

namespace Task6
{
    class use
    {
        public static void Pause()
        {
            Console.Write("Нажмите любую кравишу, чтобы продолжить");
            Console.ReadKey();
        }

        public static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            use.Print("Hello, World!");
            use.Pause();
        }
    }
}
