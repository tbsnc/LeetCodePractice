using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTest.KataTraining
{
    public class GetTheMainCharacter
    {
        /// <summary>
        ///  return the middle character of the word. 
        /// If the word's length is odd, return the middle character. 
        /// If the word's length is even, return the middle 2 characters.
        /// 
        /// Kata.getMiddle("testing") should return "t"
        ///Kata.getMiddle("middle") should return "dd"
        ///Kata.getMiddle("A") should return "A"
        /// 
        /// </summary>
        public GetTheMainCharacter(string s) 
        {
            GetMiddle(s);
        }

        public static string GetMiddle(string s) 
        {
            if (s.Length % 2 == 0)
            {
                return s[s.Length/2-1].ToString() + s[s.Length/2].ToString();
            }else
            {
                return s[s.Length / 2].ToString();
            }
        }

        public static string BreakCamelCase(string str) 
        {

            for(int i = 0; i < str.Length; i++)
            {

            }
            return str;
        }

    }
}
