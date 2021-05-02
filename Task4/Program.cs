using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

//Рыбко Георгий
//Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
//На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
//Используя метод проверки логина и пароля, написать программу:
//пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
//С помощью цикла do while ограничить ввод пароля тремя попытками.

namespace Task4
{
    class Program
    {
        static bool SignIn(string login, string password, int attempts)
        {
            do {
                Console.Write("Login: ");
                string uLogin = Console.ReadLine();
                Console.Write("Password: ");
                string uPassword = Console.ReadLine();

                if (login == uLogin && password == uPassword)
                    return true;
                else if (login != uLogin || password != uPassword)
                {
                    Console.Clear();
                    Console.WriteLine($"Incorrect. {--attempts} attempts left");
                }
            } while (attempts > 0);
            
            return false;
        }

        static void Main(string[] args)
        {
            if(SignIn("root", "GeekBrains", 3) == false)
                return;

            Console.WriteLine("Welcome to the program!");

            Lib.Pause();
        }
    }
}
