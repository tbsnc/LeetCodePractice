using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTest.KataTraining
{
    public class SumOfDigits
    {
        /// <summary>
        /// 
        /// Given n, take the sum of the digits of n. If that value has more than one digit, 
        /// continue reducing in this way until a single-digit number is produced. 
        /// The input will be a non-negative integer.
        /// 
        /// Examples
        /// 16  -->  1 + 6 = 7
        /// 942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
        ///132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
        ///493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2
        /// </summary>
        public SumOfDigits(long n) { DigitalRootRecursive(n); }

        public static int DigitalRootRecursive(long n)
        {
            int sum = n.ToString().Select(x => int.Parse(x.ToString())).Sum();
            if (sum.ToString().Length > 1)
            {
                DigitalRootRecursive(sum);
            }
            return sum;
        }

        public static int DigitalRoot(long n)
        {
            string numberStr = n.ToString();
            string solution = string.Empty;
            int temp = 0;

            while (solution == string.Empty || solution.Count() > 1)
            {
                for(int i = 0; i < numberStr.Length; i++)
                {
                    temp += int.Parse(numberStr[i].ToString());
                }
                solution = temp.ToString();
                numberStr = temp.ToString();
                temp = 0;
            }


            return 0;
        }
    }
}
