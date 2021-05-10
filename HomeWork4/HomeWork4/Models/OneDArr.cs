using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HomeWork4.Models
{
    class OneDArr
    {
        public int[] array;
        public OneDArr()
        {
            array = new int[0];
        }



        public OneDArr(int size, int min, int max)
        {
            Random rand = new Random();
            array = new int[size];
            for (int i = 0; i < size; i++)
                array[i] = rand.Next(min, max);
        }

        public OneDArr(string path)
        {
            if (File.Exists(path))
            {
                string[] s;
                s = File.ReadAllLines(path);
                array = Array.ConvertAll(s, int.Parse);
            }
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                foreach(int el in array)
                    sum += el;
                return sum;
            }
        }

        public int PairsMultiple3
        {
            get
            {
                int count = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if ((array[i] % 3 == 0 && array[i + 1] % 3 != 0) || (array[i] % 3 != 0 && array[i + 1] % 3 == 0))
                        count++;
                }
                return count;
            }
        }

        public int[] Inverse()
        {
            int[] arr = new int[array.Length];
            Array.Copy(array, arr, array.Length);
            for (int i = 0; i < arr.Length; i++)
                arr[i] *= (-1);
            return arr;
        }

        public void MultiplyByNum(int num)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] *= num;
        }

        public int MaxCount
        {
            get
            {
                int max = array[0];
                int Count = 0;
                foreach (int el in array)
                    if (el > max)
                        max = el;
                foreach (int el in array)
                    if (el == max)
                        Count++;
                return Count;
            }
        }

        public Dictionary<int, int> FreqArr()
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int[] arr = new int[array.Length];
            Array.Copy(array, arr, array.Length);
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                int freq = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        freq++;
                }
                try
                {
                    dict.Add(arr[i], freq);
                }
                catch
                {
                    continue;
                }
            } 
            return dict;
        }

        public override string ToString() => string.Join(" ", array);
    }
}
