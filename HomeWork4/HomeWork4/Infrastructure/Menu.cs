using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork4.Models;
using HomeWork4.Presenter;
using HomeWork4.Views;

namespace HomeWork4.Infrastructure
{
    class Menu
    {
        public void Start()
        {
            ConsoleView view = new ConsoleView();
            Auth auth = new Auth(view);
            switch (auth.SignIn(new DB(@"E:\CS-Basics\HomeWork4\Data.txt").Data, 3))
            {
                case true: break;
                case false: return;
            }
            
            Calc calc = new Calc(view);
            while (true)
            {
                view.PrintLine("Choose what array to work with: one-dimensional - button 1 | two-dimensional - button 2\n");
                switch(Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        OneDArr oneDArr = new OneDArr();
                        view.PrintLine("Choose how to fill array: file - button F | random fill - button R\n");
                        switch(Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.F: calc.Fill1DArrayFromFile(ref oneDArr);  break;
                            case ConsoleKey.R: calc.RandFill1DArr(ref oneDArr); break;
                        }
                        oneDArr.FreqArr();
                        bool flag = false;

                        view.PrintLine("Choose option: find sum of the elements - button 1\n" +
                                "============================================================\n" +
                                "multiply the array by an inputted number - button 2\n" +
                                "============================================================\n" +
                                "find number of pairs, where only one element is multiple 3 - button 3\n" +
                                "============================================================\n" +
                                "output an array with inversed signs - button 4\n" +
                                "============================================================\n" +
                                "find number of maximal elements - button 5\n" +
                                "============================================================\n" +
                                "Show numbers of appearence of each element - button 6\n");
                        while (!flag)
                        {

                            switch (Console.ReadKey(true).Key)
                            {
                                case ConsoleKey.D1: calc.Sum1Dim(oneDArr); break;
                                case ConsoleKey.D2: calc.MultiplyByNum1D(oneDArr); break;
                                case ConsoleKey.D3: calc.PairsMultiple3OneD(oneDArr); break;
                                case ConsoleKey.D4: calc.Inverse1D(oneDArr); break;
                                case ConsoleKey.D5: calc.MaxElCount1D(oneDArr); break;
                                case ConsoleKey.D6: calc.FreqDict(oneDArr); break;
                                case ConsoleKey.Escape: flag = true; break;
                            }
                        }
                        break;
                    case ConsoleKey.D2:
                        TwoDimArr twoDimArr = new TwoDimArr();
                        view.PrintLine("Choose how to fill array: file - button F | random fill - button R\n");
                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.F: calc.Fill2DArrayFromFile( ref twoDimArr); break;
                            case ConsoleKey.R: calc.RandFill2DArr(ref twoDimArr); break;
                        }
                        flag = false;
                        view.PrintLine("Choose option: find the greatest element - button 1\n" +
                            "============================================================\n" +
                            "find the smallest element - button 2\n" +
                            "============================================================\n" +
                            "find the number of the greatest element - button 3\n" +
                            "============================================================\n" +
                            "find sum of elements - button 4\n" +
                            "============================================================\n" +
                            "find sum of elements greater than fixed - button 5\n" +
                            "============================================================\n" +
                            "print array to a file - button 6\n");
                        while (!flag)
                        {
                            
                            switch (Console.ReadKey(true).Key)
                            {
                                case ConsoleKey.D1: calc.MaxEL2D(twoDimArr); break;
                                case ConsoleKey.D2: calc.MinEL2D(twoDimArr); break;
                                case ConsoleKey.D3: calc.MaxElInd2D(twoDimArr); break;
                                case ConsoleKey.D4: calc.Sum2Dim(twoDimArr); break;
                                case ConsoleKey.D5: calc.SumGreaterThanNum2D(twoDimArr); break;
                                case ConsoleKey.D6: calc.FillFile2D(twoDimArr); break;
                                case ConsoleKey.Escape: flag = true; break;
                            }
                        }
                        break;
                    case ConsoleKey.Escape: return;
                }
                
                

            }
            

        }
        
    }
}
