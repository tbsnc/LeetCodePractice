using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTest.KataTraining
{
    public class CountCharsInString
    {
        public CountCharsInString(string str)
        {
            Count(str);

        }
        /// <summary>
        /// The main idea is to count all the occurring characters in a string. If you have a string like aba, then the result should be {'a': 2, 'b': 1}.
        /// What if the string is empty? Then the result should be empty object literal, {}.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char,int> charDic = new Dictionary<char,int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (!charDic.ContainsKey(str[i]))
                {
                    charDic.Add(str[i], 1);
                }else
                {
                    charDic[str[i]]++;
                }
            }

            return charDic;
        }
    }
}
