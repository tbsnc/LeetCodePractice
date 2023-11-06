using System;
using System.Linq;

namespace LeetTest.KataTraining
{
    public class FindUnknownDigit
    {

        public FindUnknownDigit() { solveExpression("-?56373--9216=-?47157"); }


        /// <summary>
        ///Write code to determine the missing digit or unknown rune
        ///Expression will always be in the form
        ///(number)[opperator](number)=(number)
        ///Unknown digit will not be the same as any other digits used in expression    Assert.AreEqual(2, Runes.solveExpression("1+1=?"), "Answer for expression '1+1=?' ");
        /// Assert.AreEqual(6, Runes.solveExpression("123*45?=5?088"), "Answer for expression '123*45?=5?088' ");      
        ///Assert.AreEqual(0, Runes.solveExpression("-5?*-1=5?"), "Answer for expression '-5?*-1=5?' ");
        ///Assert.AreEqual(-1, Runes.solveExpression("19--45=5?"), "Answer for expression '19--45=5?' ");
        ///Assert.AreEqual(5, Runes.solveExpression("??*??=302?"), "Answer for expression '??*??=302?' ");
        ///Assert.AreEqual(2, Runes.solveExpression("?*11=??"), "Answer for expression '?*11=??' ");
        ///Assert.AreEqual(2, Runes.solveExpression("??*1=??"), "Answer for expression '??*1=??' ");
        ///Assert.AreEqual(-1, Runes.solveExpression("??+??=??"), "Answer for expression '??+??=??' ");
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static int solveExpression(string expression)
        {
            int missingDigit = -1;

            string result = expression.Split('=')[1];
            string expr = expression.Split('=')[0];
            bool checkNegative = true;
            bool startAtOne = false;

            string tempNumber = "";

            string number1 = "";
            string number2 = "";

            Console.WriteLine(expression);

            for (int i = 0; i < expr.Length; i++)
            {
                if (expr[i] == '-' && checkNegative)
                {
                    tempNumber += '-';
                    checkNegative = false;
                    continue;
                }
                if (new char[] { '+', '-', '*' }.Any(x => x == expr[i]))
                {
                    checkNegative = true;
                    number1 = tempNumber;
                    number2 = expr.Substring(i + 1, expr.Length - i - 1);
                    switch (expr[i])
                    {
                        case '+':
                            if (((number1[0] == '?' && number1.Length > 1) || (number2[0] == '?' && number2.Length > 1) || (result[0] == '?' && result.Length > 1)) ||
                                 ((number1[0] == '-' && number1[1] == '?' && number1.Length > 2) || (number2[0] == '-' && number2[1] == '?' && number2.Length > 2) || (result[0] == '-' && result[1] == '-' && result.Length > 2))
                                 )
                            {
                                startAtOne = true;
                            }

                            for (int j = 0; j <= 9; j++)
                            {

                                if (startAtOne)
                                {
                                    startAtOne = false;
                                    j++;
                                }
                                while (number1.Any(x => x == char.Parse(j.ToString()) || number2.Any(y => y == char.Parse(j.ToString()) ||
                                 result.Any(z => z == char.Parse(j.ToString())))))
                                {
                                    if (j + 1 > 9)
                                        return -1;
                                    j++;
                                }


                                string number1Parse = number1.Replace('?', char.Parse(j.ToString()));
                                string number2Parse = number2.Replace('?', char.Parse(j.ToString()));
                                string resultParse = result.Replace('?', char.Parse(j.ToString()));

                                if ((int.Parse(number1Parse) + int.Parse(number2Parse)) == int.Parse(resultParse))
                                {

                                    return j;
                                }


                            }
                            break;
                        case '*':
                            if (((number1[0] == '?' && number1.Length > 1) || (number2[0] == '?' && number2.Length > 1) || (result[0] == '?' && result.Length > 1)) ||
                                ((number1[0] == '-' && number1[1] == '?' && number1.Length > 2) || (number2[0] == '-' && number2[1] == '?' && number2.Length > 2) || (result[0] == '-' && result[1] == '-' && result.Length > 2))
                                )
                            {
                                startAtOne = true;
                            }

                            for (int j = 0; j <= 9; j++)
                            {

                                if (startAtOne)
                                {
                                    startAtOne = false;
                                    j++;
                                }

                                while (number1.Any(x => x == char.Parse(j.ToString()) || number2.Any(y => y == char.Parse(j.ToString()) ||
                                 result.Any(z => z == char.Parse(j.ToString())))))
                                {
                                    if (j + 1 > 9) return -1;
                                    j++;
                                }



                                string number1Parse = number1.Replace('?', char.Parse(j.ToString()));
                                string number2Parse = number2.Replace('?', char.Parse(j.ToString()));
                                string resultParse = result.Replace('?', char.Parse(j.ToString()));

                                if ((int.Parse(number1Parse) * int.Parse(number2Parse)) == int.Parse(resultParse))
                                {
                                    return j;
                                }


                            }
                            break;
                        case '-':

                            if (((number1[0] == '?' && number1.Length > 1) || (number2[0] == '?' && number2.Length > 1) || (result[0] == '?' && result.Length > 1)) ||
                              ((number1[0] == '-' && number1[1] == '?' && number1.Length > 2) || (number2[0] == '-' && number2[1] == '?' && number2.Length > 2) || (result[0] == '-'&& result[1] == '-' && result.Length > 2))
                              )
                            {
                                startAtOne = true;
                            }

                            for (int j = 0; j <= 9; j++)
                            {

                                if (startAtOne)
                                {
                                    startAtOne = false;
                                    j++;
                                }


                                while (number1.Any(x => x == char.Parse(j.ToString()) || number2.Any(y => y == char.Parse(j.ToString()) ||
                             result.Any(z => z == char.Parse(j.ToString())))))
                                {
                                    if (j + 1 > 9) return -1;
                                    j++;
                                }

                                string number1Parse = number1.Replace('?', char.Parse(j.ToString()));
                                string number2Parse = number2.Replace('?', char.Parse(j.ToString()));
                                string resultParse = result.Replace('?', char.Parse(j.ToString()));

                                if ((int.Parse(number1Parse) - int.Parse(number2Parse)) == int.Parse(resultParse))
                                {
                                    return j;
                                }
                            }
                            break;
                    }


                }
                else
                {
                    tempNumber += expr[i];
                    checkNegative = false;
                }
            }
            return missingDigit;
        }
    }
}
