using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTest.KataTraining
{
    public class TheObservedPIN
    {

        public TheObservedPIN() 
        {
            GetPINs("asd");
        }

        /// <summary>
        /// 
        /// keypad:
        ///┌───┬───┬───┐
        ///│ 1 │ 2 │ 3 │
        ///├───┼───┼───┤
        ///│ 4 │ 5 │ 6 │
        ///├───┼───┼───┤
        ///│ 7 │ 8 │ 9 │
        ///└───┼───┼───┘
        ///    │ 0 │
        ///    └───┘
        ///    
        /// He noted the PIN 1357, but he also said, it is possible that each of the digits he saw could actually be another adjacent digit 
        /// (horizontally or vertically, but not diagonally).
        /// E.g. instead of the 1 it could also be the 2 or 4. And instead of the 5 it could also be the 2, 4, 6 or 8.
        /// 
        /// all combinations of PIN with a length of 1 to 8 digits
        /// 
        /// </summary>
        /// <param name="observed"></param>
        /// <returns></returns>
        public static List<string> GetPINs(string observed)
        {
            Dictionary<string, string[]> dictAdj = new Dictionary<string, string[]>();

            //all adjacent
            for (int i = 0; i < observed.Length; i++)
            {
                switch (observed[i])
                {
                    case '0':
                        dictAdj[observed[i].ToString()] = new string[] { "8" };
                        break;
                    case '1':
                        dictAdj[observed[i].ToString()] = new string[] { "2", "4" };
                        break;
                    case '2':
                        dictAdj[observed[i].ToString()] = new string[] { "1", "3", "5" };
                        break;
                    case '3':
                        dictAdj[observed[i].ToString()] = new string[] { "2", "6" };
                        break;
                    case '4':
                        dictAdj[observed[i].ToString()] = new string[] { "1", "5", "7" };
                        break;
                    case '5':
                        dictAdj[observed[i].ToString()] = new string[] { "2", "4", "6", "8" };
                        break;
                    case '6':
                        dictAdj[observed[i].ToString()] = new string[] { "3", "5", "9" };
                        break;
                    case '7':
                        dictAdj[observed[i].ToString()] = new string[] { "4", "8" };
                        break;
                    case '8':
                        dictAdj[observed[i].ToString()] = new string[] { "0", "5", "7", "9" };
                        break;
                    case '9':
                        dictAdj[observed[i].ToString()] = new string[] { "6", "8" };
                        break;
                    default:
                        return new List<string>();
                       
                }

            }
            List<string> solution = new List<string>() {"" };
            List<string> combinations = new List<string>();
            Dictionary<int, string[]> possibleComb = new Dictionary<int, string[]>();
    

            for (int i = 0; i < observed.Length; i++)
            {
                combinations.Add(observed[i].ToString());       
                foreach (var item in dictAdj[observed[i].ToString()])
                {
                    combinations.Add(item);
                }
                possibleComb[i] = combinations.ToArray();
                combinations.Clear();
            }

            foreach (var inner in possibleComb.Values)
            {

                solution = solution.SelectMany(x => inner.Select(r => x + r)).ToList();
               
            }

            return solution;
        }
    }
}
