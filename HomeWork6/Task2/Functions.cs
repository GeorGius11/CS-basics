using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Functions
    {
        public double[] FillSaveFunc()
        {
            double[] values = new double[3];
            Console.WriteLine("Input the first and the last number:\n--> ");
            values[0] = Double.Parse(Console.ReadLine());
            Console.WriteLine("Input the last and the last number:\n--> ");
            values[1] = Double.Parse(Console.ReadLine());
            Console.WriteLine("Input the interval:\n--> ");
            values[2] = Double.Parse(Console.ReadLine());
            return values;
        }

        /// <summary>
        /// Uses the formula x*x - 50*x + 10
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double SomeF(double x)
        {
            return x * x - 50 * x + 10;
        }
        public double Sin(double x)
        {
            return Math.Sin(x);
        }
        public double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        public void SaveFunc(Fun F, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;
            }

            fs.Close();
            bw.Close();
        }

        public double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            min = double.MaxValue;
            double d;

            double[] arr = new double[fs.Length / sizeof(double)];

            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = br.ReadDouble();
                arr[i] = d;
                if (d < min) min = d;
            }

            fs.Close();
            br.Close();

            return arr;
        }

        public void ShowDoublesAndMin(double[] arr, double min)
        {
            Console.WriteLine(String.Join(";", arr));
            Console.WriteLine($"The minimal value is {min}");
        }
    }
}
