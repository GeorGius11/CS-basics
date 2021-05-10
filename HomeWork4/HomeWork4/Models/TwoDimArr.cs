using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork4.Models
{
    class TwoDimArr
    {
        int[,] array;
        
        public TwoDimArr()
        {
            array = new int[0, 0];
        }

        public TwoDimArr(int rows, int columns, int min, int max)
        {
            array = new int[rows, columns];
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = rand.Next(min, max);
                }
            }
        }

        public TwoDimArr(string path)
        {
            if (File.Exists(path))
            {
                string[] s;
                s = File.ReadAllLines(path);
                array = new int[s.Length, s[0].Split(' ', '\t').Length];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = int.Parse(s[i].Split(' ', '\t')[j]);
                    }
                }
            }
        }

        public int MinEl
        {
            get 
            {
                int min = array[0, 0];
                foreach (int el in array)
                    if (el < min)
                        min = el;
                return min;
            }
        }

        public int MaxEl
        {
            get
            {
                int max = array[0, 0];
                foreach (int el in array)
                    if (el > max)
                        max = el;
                return max;
            }
        }

        public int MaxElInd
        {
            get
            {
                int max = array[0, 0];
                int num = 0, ans = -1;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        num++;
                        if (array[i, j] > max)
                        {
                            max = array[i, j];
                            ans = num;
                        }
                    }
                }
                return ans;
            }
        }

        public int Sum()
        {
            int sum = 0;
            foreach (int el in array)
                sum += el;
            return sum;
        }

        public int SumGreater(int n)
        {
            int sum = 0;
            foreach (int el in array)
            {
                if (el > n)
                    sum += el;
            }
            return sum;
        }

        public void FillFile(string path)
        {
            string s = string.Empty;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    s += $"{array[i, j]} ";
                }
                s += "\n";
            }
            if(File.Exists(path))
                File.WriteAllText(path, s);
        }

        public override string ToString()
        {
            string s = string.Empty;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    s += $"{array[i, j]} ";
                }
                s += "\n";
            }
            return s;
        }

    }
}
