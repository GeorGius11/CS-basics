using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    delegate double Fun(double x);
    class Menu
    {
        public void Start()
        {
            Functions functions = new Functions();
            Fun[] funs = new Fun[] { functions.SomeF, functions.Sin, functions.Sqrt };

            double[] values = functions.FillSaveFunc();
            double min;

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1: functions.SaveFunc(funs[0], "File.bin", values[0], values[1], values[2]);
                    
                    break;
                case ConsoleKey.D2: functions.SaveFunc(funs[1], "File.bin", values[0], values[1], values[2]);
                    
                    break;
                case ConsoleKey.D3: functions.SaveFunc(funs[2], "File.bin", values[0], values[1], values[2]); break;
            }

            functions.ShowDoublesAndMin(functions.Load("File.bin", out min), min);
            
            Console.ReadKey();
        }
    }
}
