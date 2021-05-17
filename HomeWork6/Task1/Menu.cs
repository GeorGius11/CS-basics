using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Menu
    {
        public void Start()
        {
            Functions functions = new Functions();
            functions.Table(functions.MyFunc, 1, 1, 5);
            functions.Table(functions.MyFunc2, 1, 1, 5);
            Console.ReadKey();
        }
        

        
    }
}
