using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTest.KataTraining
{
    internal class Array_diff
    {
        /// <summary>
        /// Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.

        ///It should remove all values from list a, which are present in list b keeping their order.
        /// </summary>
        public Array_diff(int[] a, int[] b) 
        { 
            ArrayDiff(a, b);
        }

        public static int[] ArrayDiff(int[] a, int[] b)
        {

            List<int> listA = a.ToList();
            List<int> listB = b.ToList();

            foreach (int i in listB)
            {
                if (listA.Any(x => x == i))
                {
                    listA.RemoveAll(x => x ==i);
                }
            }

            return listA.ToArray();
        }
    }
}
