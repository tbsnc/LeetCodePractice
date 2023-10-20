using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTest
{
    internal class _17_LetterCombinationsPhoneNuber
    {
        public _17_LetterCombinationsPhoneNuber(string digits) {
            LetterCombinations(digits);
        }


        public IList<string> LetterCombinations(string digits)
        {
            List<List<string>> list = new List<List<string>>();

            IEnumerable<string> solution = new List<string>() {null };

            Dictionary<int, string> numberTable = new Dictionary<int, string>() {
                { 2, "abc"},
                { 3, "def"},
                { 4, "ghi" },
                { 5, "jkl" },
                { 6, "mno" },
                { 7, "pqrs" },
                { 8, "tuv" },
                { 9, "wxyz" }
            };

            List<string[]> temp= new List<string[]>();
            

            for (int i = 0; i < digits.Length; i++)
            {
                string current = numberTable.First(x => x.Key == int.Parse(digits[i].ToString())).Value;
                List<string> arrString = new List<string>();
                for (int j = 0; j < current.Length; j++)
                {
                    arrString.Add( current[j].ToString());
                }
                list.Add(arrString);
            }

            

            foreach (var l in list)
            {
                solution = solution.SelectMany(x => l.Select(y => x + y));
            }





            return solution.Any(x => x== null) ? new List<string> { } : solution.ToList(); 
        }
    }
}
