using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LeetTest.KataTraining
{
    public class YourOrderPlease
    {
        public YourOrderPlease() 
        {
            Order("s2 Thi1s T4est 3a");
        }

        /// <summary>
        /// Your task is to sort a given string. Each word in the string will contain a single number. 
        /// This number is the position the word should have in the result.
        /// Note: Numbers can be from 1 to 9. So 1 will be the first word(not 0).
        /// If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        /// 
        
        public static string OrderCrazyLinq(string words)
        {
            if (string.IsNullOrEmpty(words)) return words;

            return string.Join(" ", words.Split(' ').OrderBy(x => x.ToList().Find(c => char.IsDigit(c))));
        }
        public static string Order(string words)
        {
            if (words.Length == 0) return words;

            Dictionary<int,string> keyValuePairs = new Dictionary<int,string>();
            string solution = string.Empty;

            List<string> wordList = words.Split(' ').ToList();

            for (int i = 0; i < wordList.Count; i++)
            {
                for (int j = 0; j < wordList[i].Length; j++)
                {
                    if ((int)wordList[i][j] >= 49 && (int)wordList[i][j] <= 57)
                    {
                        keyValuePairs[int.Parse(wordList[i][j].ToString())] = wordList[i];
                    }
                }
            }

            foreach (var str in keyValuePairs.OrderBy(x => x.Key))
            {
                solution += str.Value + " ";
            }
            
            
            return solution.Trim();
        }
    }
}
