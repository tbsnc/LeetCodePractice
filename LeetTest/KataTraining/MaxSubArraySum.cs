using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTest.KataTraining
{
    public class MaxSubArraySum
    {
        public MaxSubArraySum()
        {
            MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4});
        }
        /// <summary>
        /// The maximum sum subarray problem consists in finding the maximum sum of a contiguous subsequence in an array or list of integers:
        /// Easy case is when the list is made up of only positive numbers and the maximum sum is the sum of the whole array. 
        /// If the list is made up of only negative numbers, return 0 instead.
        /// Empty list is considered to have zero greatest sum. Note that the empty list or array is also a valid sublist/subarray.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int MaxSequence(int[] arr)
        {
            int solution = 0;
            int maxSum = 0;

            if(Array.Find(arr, (x) => x > 0) == 0) return 0;

            if (Array.Find(arr, (x) => x < 0) == 0)
            {
                solution = arr.Sum();
            }

            int left = 0;
            int tempSum = 0;
            for (int i = arr.Length - 1; i > 0; i--)
            {

                for (int j = 0; j < i; j++)
                {
                    left = j;
                    tempSum += arr[i];

                    while (left < i)
                    {
                        tempSum += arr[left];

                        left++;
                    }
                    if (maxSum < tempSum)
                    {
                        maxSum = tempSum;
                    }
                    tempSum = 0;

                }
            }

            return maxSum;
        }
    }
}
