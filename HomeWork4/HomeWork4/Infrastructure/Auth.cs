using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HomeWork4.Infrastructure;

namespace HomeWork4
{
    class Auth
    {

        public bool SignIn(string[,] data, int attempts)
        {
            do
            {
                Console.Write("Login: ");
                string uLogin = Console.ReadLine();
                Console.Write("Password: ");
                string uPassword = Console.ReadLine();

                for (int i = 0; i < data.GetLength(0); i++)
                {
                    if (data[i, 0] == uLogin && data[i, 1] == uPassword)
                        return true;
                    else if (data[i, 0] != uLogin || data[i, 1] != uPassword)
                    {
                        Console.Clear();
                        Console.WriteLine($"Incorrect. {--attempts} attempts left");
                    }
                }
                
            } while (attempts > 0);

            return false;
        }
    }
}
