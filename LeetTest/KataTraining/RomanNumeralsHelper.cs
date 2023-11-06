using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace LeetTest.KataTraining
{
    public class RomanNumeralsHelper
    {
        public RomanNumeralsHelper()
        {
            ToRoman(1666);
            FromRoman("XLIV");
        }
        /// <summary>
        /// Write two functions that convert a roman numeral to and from an integer value. 
        /// Multiple roman numeral values will be tested for each function.
        /// 2539
        /// MMDXXXIX
        /// 
        /// to roman:
        ///2000 -> "MM"
        ///1666 -> "MDCLXVI"
        ///1000 -> "M"
        ///400 -> "CD"
        ///90 -> "XC"
        ///40 -> "XL"
        ///1 -> "I"
        ///
        ///from roman:
        ///"MM"      -> 2000
        ///"MDCLXVI" -> 1666
        ///"M"       -> 1000
        ///"CD"      -> 400
        ///"XC"      -> 90
        ///"XL"      -> 40
        ///"I"       -> 1
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string ToRoman(int n)
        {

            string solution = "";

            if (n / 1000 > 0)
            {
                for (int i = 0; i < n / 1000; i++)
                {
                    solution += "M";
                }
                n = n - (n / 1000 * 1000);
            }
            if (n / 100 > 0)
            {
                switch (n / 100)
                {
                    case 1:
                    case 2:
                    case 3:
                        for (int i = 0; i < n / 100; i++)
                        {
                            solution += "C";
                        }
                        break;
                    case 4:
                        solution += "CD";
                        break;
                    case 5:
                        solution += "D";
                        break;
                    case 6:
                    case 7:
                    case 8:
                        solution += "D";
                        for (int i = 0; i < n / 100 - 5; i++)
                        {
                            solution += "C";
                        }
                        break;
                    case 9:
                        solution += "CM";
                        break;

                }
                n = n - (n / 100 * 100);
            }

            if (n / 10 > 0)
            {
                switch (n / 10)
                {
                    case 1:
                    case 2:
                    case 3:
                        for (int i = 0; i < n / 10; i++)
                        {
                            solution += "X";
                        }
                        break;
                   case 4:
                        solution += "XL";
                        break;
                    case 5:
                        solution += "L";
                        break;
                    case 6:
                    case 7:
                    case 8:
                        solution += "L";
                        for (int i = 0; i < n / 10 - 5; i++)
                        {
                            solution += "X";
                        }
                        break;
                    case 9:
                        solution += "XC";
                        break;

                }
                n = n - (n / 10 * 10);
            }
            switch (n)
            {
                case 1:
                case 2:
                case 3:
                    for (int i = 0; i < n ; i++)
                    {
                        solution += "I";
                    }
                    break;
                case 4:
                    solution += "IV";
                    break;
                case 5:
                    solution += "V";
                    break;
                case 6:
                case 7:
                case 8:
                    solution += "V";
                    for (int i = 0; i < n - 5; i++)
                    {
                        solution += "I";
                    }
                    break;
                case 9:
                    solution += "IX";
                    break;

            }

            return solution;
        }

        public static int FromRoman(string romanNumeral)
        {
            Dictionary<char,int> romanValues = new Dictionary<char,int>();
            int r = 1;

            romanValues['I'] = 1;
            romanValues['V'] = 5;
            romanValues['X'] = 10;
            romanValues['L'] = 50;
            romanValues['C'] = 100;
            romanValues['D'] = 500;
            romanValues['M'] = 1000;

            int solution = 0;
            

            if (romanNumeral.Length == 1)
            {
                return romanValues[romanNumeral[0]];
            }

            for (int i = 0; i < romanNumeral.Length; i++)
            {
                if (i == romanNumeral.Length - 1)
                {
                    if (romanValues[romanNumeral[i]] > romanValues[romanNumeral[i - 1]]) return solution;
                    solution += romanValues[romanNumeral[i]];
                    return solution;
                }
              
                ///44 -> "XLIV"
                if (romanValues[romanNumeral[i]] == romanValues[romanNumeral[i + 1]])
                {
                    solution += romanValues[romanNumeral[i]];
                }
                else if (romanValues[romanNumeral[i]] > romanValues[romanNumeral[i + 1]])
                {
                    solution += romanValues[romanNumeral[i]];
                }
                else if (romanValues[romanNumeral[i]] < romanValues[romanNumeral[i + 1]])
                {
                    solution += romanValues[romanNumeral[i + 1]] - romanValues[romanNumeral[i]];
                    i++;
                }
                
            }


            return solution;
        }


    }
}
