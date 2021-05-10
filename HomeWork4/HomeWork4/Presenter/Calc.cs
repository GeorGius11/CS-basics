﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Calc
    {
        View view;

        public Calc(View view)
        {
            this.view = view;
        }

        public void RandFill1DArr(ref OneDArr arr)
        {
            view.Print("Input size of the array: --> ");
            int size = Convert.ToInt32(view.Input());
            view.Print("Input minimal elements of the array: --> ");
            int min = Convert.ToInt32(view.Input());
            view.Print("Input maximal elements of the array: --> ");
            int max = Convert.ToInt32(view.Input());
            arr = new OneDArr(size, min, max);
            view.PrintLine($"The array:\n{arr}\n");

        }

        public void RandFill2DArr(ref TwoDimArr arr)
        {
            view.Print("Input number of rows: --> ");
            int row = Convert.ToInt32(view.Input());
            view.Print("Input number of columns: --> ");
            int col = Convert.ToInt32(view.Input());
            view.Print("Input minimal elements of the array: --> ");
            int min = Convert.ToInt32(view.Input());
            view.Print("Input maximal elements of the array: --> ");
            int max = Convert.ToInt32(view.Input());
            arr = new TwoDimArr(row, col, min, max);
            view.PrintLine($"The array:\n{arr}\n");
        }

        public void Fill1DArrayFromFile(ref OneDArr arr)
        {
            view.Print("Input the path to the file: --> ");
            string path = view.Input();
            arr = new OneDArr(@path);
            view.PrintLine($"The array:\n{arr}\n");
        }

        public void Fill2DArrayFromFile(ref TwoDimArr arr)
        {
            view.Print("Input the path to the file: --> ");
            string path = view.Input();
            arr = new TwoDimArr(@path);
            view.PrintLine($"The array:\n{arr}\n");
        }

        public void PairsMultiple3OneD(OneDArr arr)
        {
            view.PrintLine($"number of pairs, where only one element is multiple 3 is {arr.PairsMultiple3}");
        }

        public void Sum1Dim(OneDArr arr)
        {
            view.PrintLine("Sum  of the elements of the array is " + Convert.ToString(arr.Sum));
        }

        public void Inverse1D(OneDArr arr)
        {
            int[] inv = arr.Inverse();
            string s = string.Empty;
            foreach (int el in inv)
                s += $"{el} ";
            view.PrintLine(s);
        }

        public void MultiplyByNum1D(OneDArr arr)
        {
            view.Print("Input any number: --> ");
            int n = Convert.ToInt32(view.Input());
            arr.MultiplyByNum(n);
            view.PrintLine("Changed array:\n" + arr.ToString());
        }

        public void MaxElCount1D(OneDArr arr)
        {
            view.PrintLine($"Number of maximal elements is {arr.MaxCount}");
        }

        public void MaxEL2D(TwoDimArr arr)
        {
            view.PrintLine("The greatest element of the array is " + Convert.ToString(arr.MaxEl));
        }

        public void MinEL2D(TwoDimArr arr)
        {
            view.PrintLine("The smallest element of the array is " + Convert.ToString(arr.MinEl));
        }

        public void MaxElInd2D(TwoDimArr arr)
        {
            view.PrintLine("The number of the greatest element of the array is " + Convert.ToString(arr.MaxElInd));
        }

        public void Sum2Dim(TwoDimArr arr)
        {
            view.PrintLine("Sum  of the elements of the array is " + Convert.ToString(arr.Sum()));
        }

        public void SumGreaterThanNum2D(TwoDimArr arr)
        {
            view.Print("Input some number: --> ");
            int num = int.Parse(view.Input());
            view.PrintLine($"Sum  of the elements greater than {num} is {arr.SumGreater(num)}");
        }

        public void FillFile2D(TwoDimArr arr)
        {
            view.Print("Input the path to the file: --> ");
            string path = view.Input();
            arr.FillFile(@path);
        }

        public void FreqDict(OneDArr arr)
        {
            Dictionary<int, int> dict;
            dict = arr.FreqArr();
            foreach (KeyValuePair<int, int> keyValuePair in dict)
            {
                Console.WriteLine($"{keyValuePair.Key} - {keyValuePair.Value}");
            }
        }
    }
}
