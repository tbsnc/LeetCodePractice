using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetTest.KataTraining
{
    public class SimplePigLatin
    {

        public SimplePigLatin() {
            PigIt("  Hello world !");
        }

        /// <summary>
        /// Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string PigIt(string str)
        {
            string solution = string.Empty;
            string tempItem = string.Empty;
            string tempSwitch = string.Empty;
            bool switchEnd = false;

            if (str.Trim().Length == 0) return "";
            foreach (var item in str.Trim().Split(' '))
            {
                if (item.Trim().Length == 0) return "";
                if (item.Any(x => (x < 65 || x > 122) || (x > 90 && x < 97)))
                {
                    if (item.Length == 0) return "";
                    tempSwitch = item.Substring(item.Length - 1, 1);

                    switchEnd = true;
                }


                if (switchEnd)
                {
                    if (item == tempSwitch)
                    {
                        solution += item;
                    }
                    else
                    {
                        tempItem = item.Substring(1, item.Length - 2) + item.Substring(0, 1) + "ay" + tempSwitch;
                    }
                    switchEnd = false;
                }
                else
                {
                    if (item.Length == 0) return "";
                    tempItem = item.Substring(1, item.Length - 1) + item.Substring(0, 1) + "ay";
                }

                solution += tempItem + " ";
                tempItem = string.Empty;
            }
            return solution.Trim();
        }
    }
}
