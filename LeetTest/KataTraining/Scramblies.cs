using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTest.KataTraining
{
    public class Scramblies
    {

        public Scramblies() 
        {
            Scramble("a", "aa");
        }

        /// <summary>
        ///Complete the function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2, 
        ///otherwise returns false.
        ///Only lower case letters will be used (a-z). No punctuation or digits will be included.
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static bool Scramble(string str1, string str2)
        {

            Dictionary<char,int> tempDic= new Dictionary<char,int>();
           
            for(int i = 0; i <str2.Length; i++)
            {
                if (tempDic.ContainsKey(str2[i]))
                {
                    tempDic[str2[i]]++;
                }
                else
                {
                    tempDic[str2[i]] = 1;
                }
                
            }
            for(int i = 0;i <str1.Length; i++)
            {
                if (tempDic.ContainsKey(str1[i]))
                {
                    tempDic[str1[i]]--;
                }
            }

            return !tempDic.Any(x => x.Value > 0);
        }
    }
}
