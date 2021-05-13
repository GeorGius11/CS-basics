using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task1_3.Models
{
    class Model
    {
        /// <summary>
        /// Checks whether inputted login is valid i.e. is 2-10 letters long, containing only 
        /// latin letters or numbers(number cannot be the first letter). Returns true if login
        /// is valid, otherwise - false.
        /// </summary>
        /// <param name="login">Login for validation</param>
        /// <returns></returns>
        public bool ValidateLogin(string login)
        {
            Regex regex = new Regex(@"^\D[a-zA-Z\d]{2,9}$", RegexOptions.ExplicitCapture);
            return regex.IsMatch(login);
        }

        /// <summary>
        /// returns string which contains only words numbers of letters of 
        /// which are not longer than the specified number
        /// </summary>
        /// <param name="msg">String to check</param>
        /// <param name="n">Specified number of letters</param>
        /// <returns></returns>
        public string WordsNotLongerThanNum(string msg, int n)
        {
            string[] words = msg.Split(' ');
            StringBuilder res = new StringBuilder();
            foreach (string word in words)
                if (word.Length <= n)
                    res.Append(word + " ");
            
            return res.ToString();
        }


        /// <summary>
        /// Deletes words which end with the specified character
        /// </summary>
        /// <param name="msg">String</param>
        /// <param name="c">Char</param>
        /// <returns>Returns a string without deleted words</returns>
        public string DeleteWords(string msg, char c)
        {
            string[] words = msg.Split(' ');
            StringBuilder res = new StringBuilder();
            foreach (string word in words)
            {
                if (word[word.Length - 1] == c)
                    continue;
                res.Append(word + " ");
            }
            return Convert.ToString(res);
        }

        /// <summary>
        /// Returns the first word with the greatest length
        /// </summary>
        /// <param name="msg">String to search for the word</param>
        /// <returns></returns>
        public string LongestWord(string msg)
        {
            string[] words = msg.Split(' ');
            string MaxWord = words[0];
            foreach (string word in words)
            {
                if (word.Length > MaxWord.Length)
                    MaxWord = word;
            }
            return MaxWord;
        }

        /// <summary>
        /// Returns the string which contains all words with the greatest length
        /// </summary>
        /// <param name="msg">String to search for the word</param>
        /// <returns></returns>
        public string LongestWords(string msg)
        {
            int MaxLength = LongestWord(msg).Length;
            string[] words = msg.Split(' ');
            StringBuilder res = new StringBuilder();
            foreach (string word in words)
            {
                if (word.Length == MaxLength)
                    res.Append(word + " ");
            }
            return Convert.ToString(res);
        }

        /// <summary>
        /// Returns frequency dictionary. Keys are inputted words.
        /// Values are numbers of appearences of these words 
        /// in the inputted string
        /// </summary>
        /// <param name="words">Words</param>
        /// <param name="text">String</param>
        /// <returns></returns>
        public Dictionary<string, int> FreqArr(string[] words, string text)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string word in words)
            {
                Regex regex = new Regex(word);
                dict.Add(word, regex.Matches(text).Count);
            }
            return dict;

        }

        /// <summary>
        /// Checks whether one string is a reshuffle of another
        /// </summary>
        /// <param name="a">First string</param>
        /// <param name="b">Second string</param>
        /// <returns>True if strings are reshuffles of each other, 
        /// otherwise - false</returns>
        public bool IsReshuffle(string a, string b)
        {
            char[] aa = a.ToCharArray();
            Array.Sort(aa);
            char[] bb = b.ToCharArray();
            Array.Sort(bb);
            a = String.Join("", aa);
            b = String.Join("", bb);
            if (a.CompareTo(b) == 0)
                return true;
            return false;
        }
    }
}
