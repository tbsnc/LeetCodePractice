using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTest.KataTraining
{
    public class BreakCamelCase
    {
        public BreakCamelCase(string str) 
        {
            BreakcamelCase(str);
        }
        public static string BreakcamelCase(string str)
        {
            int start = 0;

            List<string> solutions = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == str[i].ToString().ToUpper())
                {
                    solutions.Add(str.Substring(start, i - start));
                    start = i;
                }
            }
            if (start < str.Length)
            {
                solutions.Add(str.Substring(start, str.Length - start));
            }

            string sol = "";
            foreach (string s in solutions)
            {
                sol += s + " ";
            }
            return sol.Trim();
        }

    }
}
