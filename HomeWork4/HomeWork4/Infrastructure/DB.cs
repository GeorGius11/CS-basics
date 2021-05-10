using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HomeWork4.Infrastructure
{
    class DB
    {
        string[,] data;
        
        public DB(string path)
        {
            string[] s = File.ReadAllLines(path);
            data = new string[s.Length, 2];
            for (int i = 0; i < s.Length; i++)
            {
                data[i, 0] = s[i].Split(' ')[0];
                data[i, 1] = s[i].Split(' ')[1];
            }
        }

        public string[,] Data
        {
            get { return data; }
        }
    }
}
