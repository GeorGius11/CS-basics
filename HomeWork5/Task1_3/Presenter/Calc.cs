using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_3.Views;
using Task1_3.Models;

namespace Task1_3.Presenter
{
    class Calc
    {
        View view;
        Model model;

        public Calc(View view)
        {
            this.view = view;
            model = new Model();
        }

        public void ShowMenu()
        {
            view.Print("Choose option:\n\nTo validate your login - press 1\n" +
                    "===========================================================================================\n" +
                    "To see words numbers of letters of which are not longer than the specified number - press 2\n" +
                    "===========================================================================================\n" +
                    "To delete words which end with specified letter from a string - press 3\n" +
                    "===========================================================================================\n" +
                    "To find the first longest word in a string - press 4\n" +
                    "===========================================================================================\n" +
                    "To find all the longest words in a string - press 5\n" +
                    "===========================================================================================\n" +
                    "To see the frequency of words in a string - press 6\n" +
                    "===========================================================================================\n" +
                    "To check whether two strings are reshuffles of each other - press 7\n" +
                    "===========================================================================================\n" +
                    "To see menu again - press 8\n" +
                    "===========================================================================================\n" +
                    "To exit - press ESCAPE\n\n");
        }
            
        public void ValidateLogin()
        {
            view.Print("Valid login is considered to be 2-10 letters long, containing only " +
                "latin letters or numbers\n(number cannot be the first letter)\n\nInput your login:--> ");
            string login = view.Input();
            switch(model.ValidateLogin(login))
            {
                case true: view.PrintLine("Your login is valid\n"); break;
                case false: view.PrintLine("Your login is invalid\n"); break;
            }
        }

        public void WordsNotLongerThanNum()
        {
            view.Print("Input length to check the words:--> ");
            int n = int.Parse(view.Input());
            view.Print("Input your string:\n--> ");
            string str = view.Input();
            view.PrintLine("\nString which contains only words numbers of letters " +
                "of which are not longer than the specified number:\n" 
                + model.WordsNotLongerThanNum(str, n) + "\n");
        }

        public void DeleteWordsEndingWithChar()
        {
            view.Print("Input any letter: --> ");
            Char c = Char.Parse(view.Input());
            view.Print("Input string:\n--> ");
            string s = view.Input();
            view.Print($"\nString without words which end with {c}:\n{model.DeleteWords(s, c)}\n\n");
        }

        public void LongestWord()
        {
            view.Print("Input string:\n--> ");
            string s = view.Input();
            view.PrintLine($"\nThe first longest word in the string is {model.LongestWord(s)}\n");
        }

        public void LongestWords()
        {
            view.Print("Input string:\n--> ");
            string s = view.Input();
            view.PrintLine($"\nThe longest words in the string are:\n{model.LongestWords(s)}\n");
        }

        public void FreqArr()
        {
            view.Print("Input words (separated with space):\n--> ");
            string[] words = view.Input().Split(' ');
            view.Print("Input string:\n--> ");
            string s = view.Input();
            view.Print($"\nThe frequencies of words appearecnces in the string:\n");
            Dictionary<string, int> dict = model.FreqArr(words, s);
            foreach (var item in dict)
            {
                view.PrintLine($"{item.Key} - {item.Value}");
            }
            view.PrintLine("");
        }

        public void IsReshuffle()
        {
            view.Print("Input first string:\n--> ");
            string s1 = view.Input();
            view.Print("\nInput second string:\n--> ");
            string s2 = view.Input();

            switch(model.IsReshuffle(s1, s2))
            {
                case true: view.PrintLine("\nThe strings are reshuffles of each other\n"); break;
                case false: view.PrintLine("\nThe strings are not reshuffles of each other\n"); break;
            }
        }
    }
}
