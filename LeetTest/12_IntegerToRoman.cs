using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetTest
{
    internal class _12_IntegerToRoman
    {
        public _12_IntegerToRoman(int num) { 
        
            IntToRoman(num); 
        }

        public string IntToRoman(int num)
        {
            string solution = string.Empty; 
            
            Dictionary<int,string> romanIntPairs = new Dictionary<int,string>();

            romanIntPairs[1] = "I";
            romanIntPairs[4] = "IV";
            romanIntPairs[5] = "V";
            romanIntPairs[9] = "IX";
            romanIntPairs[10] = "X";
            romanIntPairs[40] = "XL";
            romanIntPairs[50] = "L";
            romanIntPairs[90] = "XC";
            romanIntPairs[100] = "C";
            romanIntPairs[400] = "CD";
            romanIntPairs[500] = "D";
            romanIntPairs[900] = "CM";
            romanIntPairs[1000] = "M";

            if (num / 1000 > 0)
            {
                for (int i = 1; i <= num / 1000; i++)
                {
                    solution += romanIntPairs[1000];
                }
                num = num - num/1000 * 1000;
            }

            if (num / 100 > 0)
            {
                if (romanIntPairs.ContainsKey(num / 100 * 100)) 
                { 
                    solution += romanIntPairs[num / 100 * 100];
                }else if (num / 100 * 100 > 500)
                {
                    solution += romanIntPairs[500];
                    int temp = num/100*100 - 500;
                    while (temp > 0) 
                    {
                        solution += romanIntPairs[100];
                        temp -= 100;
                    }
                }else
                {
                    int temp = num / 100 * 100;
                    while (temp > 0)
                    {
                        solution += romanIntPairs[100];
                        temp -= 100;
                    }
                }
                num = num - (num/100 * 100);
            }

            if (num / 10 > 0)
            {
                if (romanIntPairs.ContainsKey(num / 10 * 10))
                {
                    solution += romanIntPairs[num / 10 * 10];
                }else if (num / 10 * 10 > 50)
                {
                    solution += romanIntPairs[50];
                    int temp = num / 10 * 10 - 50;
                    while (temp > 0)
                    {
                        solution += romanIntPairs[10];
                        temp -= 10;
                    }
                }else if (num / 10 * 10 < 50)
                {
                    int temp = num / 10 * 10;
                    while (temp > 0)
                    {
                        solution += romanIntPairs[10];
                        temp -= 10;
                    }
                }
                num = num - num / 10 * 10;
            }
            if (num > 0)
            {
                if (romanIntPairs.ContainsKey(num))
                {
                    solution += romanIntPairs[num];
                }else if (num > 5)
                {
                    int temp = num - 5;
                    solution+= romanIntPairs[5];
                    while(temp > 0)
                    {
                        solution += romanIntPairs[1];
                        temp -= 1;
                    }
                }else
                {
                    while(num > 0)
                    {
                        solution += romanIntPairs[1];
                        num--;
                    }
                }
            }

            return solution;
        }

    }
}
