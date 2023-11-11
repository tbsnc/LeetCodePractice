using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LeetTest.KataTraining
{
    public class LargeFactorials
    {
        public LargeFactorials() 
        {
            Factorial(15);
        }


        /// <summary>
        /// Your mission is simple: write a function that takes an integer n and returns the value of n!.
        ///You are guaranteed an integer argument.
        ///For any values outside the non-negative range, return null, nil or None (return an empty string "" in C and C++). 
        ///For non-negative numbers a full length number is expected for example, return 25! =  "15511210043330985984000000"  as a string.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string Factorial(int n)
        {

            int start = 2;
            List<int> list = new List<int>();

            
            string solution = "";
            list.Add(1);
            int len = 1;
            int x = 0;

            int num = 0;
            while (start <= n)
            {
                x = 0;
                num = 0;
                while(x < len)
                {
                    list[x] = list[x] * start;
                    list[x] = list[x] + num;
                    num = list[x] / 10;
                    list[x] = list[x] % 10;
                    x++;
                }

                while (num != 0)
                {

                    list.Add(num % 10);
                    num = num / 10;
                    len++;
                }

                start++;
            }

            while (len > 0)
            {
                solution += list[len-1];
                len--;
            }
            return solution;
        }
    }
}
