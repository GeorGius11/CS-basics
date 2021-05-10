using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HomeWork4.Views;

namespace HomeWork4.Models
{
    class Auth
    {
        View view;

        public Auth(View view)
        {
            this.view = view;
        }

        public bool SignIn(string[,] data, int attempts)
        {
            do
            {
                view.Print("Login: ");
                string uLogin = view.Input();
                view.Print("Password: ");
                string uPassword = view.Input();

                for (int i = 0; i < data.GetLength(0); i++)
                {
                    if (data[i, 0] == uLogin && data[i, 1] == uPassword)
                        return true;
                    else if (data[i, 0] != uLogin || data[i, 1] != uPassword)
                    {
                        Console.Clear();
                        view.Print($"Incorrect. {--attempts} attempts left");
                    }
                }
                
            } while (attempts > 0);

            return false;
        }
    }
}
