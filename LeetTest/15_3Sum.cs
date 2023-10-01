using System.Collections.Generic;
using System.Linq;

namespace LeetTest
{
    internal class _15_3Sum 
    {
        public _15_3Sum(int[] nums)
        {
            // ThreeSum(nums);
            ThreeSumClosest(new int[] { 40, -53, 36, 89, -38, -51, 80, 11, -10, 76, -30, 46, -39, -15, 4, 72, 83, -25, 33, -69, -73, -100, -23, -37, -13, -62, -26, -54, 36, -84, -65, -51, 11, 98, -21, 49, 51, 78, -58, -40, 95, -81, 41, -17, -70, 83, -88, -14, -75, -10, -44, -21, 6, 68, -81, -1, 41, -61, -82, -24, 45, 19, 6, -98, 11, 9, -66, 50, -97, -2, 58, 17, 51, -13, 88, -16, -77, 31, 35, 98, -2, 0, -70, 6, -34, -8, 78, 22, -1, -93, -39, -88, -77, -65, 80, 91, 35, -15, 7, -37, -96, 65, 3, 33, -22, 60, 1, 76, -32, 22 }, 292 );
        }

        public int ThreeSumClosest(int[] nums, int target) //16 three sum closest TODO
        {
            List<int> listSums = new List<int>();
            int l, r;

            for (int i = 0; i < nums.Length; i++)
            {
            
                l = i + 1;
                r = nums.Length - 1;

                while (l < r)
                {
                    listSums.Add(nums[i] + nums[l] + nums[r]);
                    r--;
                }


            }

            if(listSums.Any(x => x == target)) return listSums.Where(x => x == target).FirstOrDefault();  
            int sol1 = listSums.Where(x => x < target).DefaultIfEmpty().Max();
            int sol2 = listSums.Where(x => x > target).DefaultIfEmpty().Min();

           

            return sol1 > sol2 ? sol1 : sol2;

        }




        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<int> numsList = new List<int>();
            numsList = nums.ToList();
            numsList.Sort();

            List<IList<int>> solution = new List<IList<int>>();
            int l, r;

            for (int i = 0; i < numsList.Count - 2; i++)
            {
                if (numsList[i] > 0) break;
                if (i > 0 && numsList[i] == numsList[i - 1])
                {
                    continue;
                }
                l = i + 1;
                r = numsList.Count - 1;

                while (l < r)
                {
                    int total = numsList[i] + numsList[l] + numsList[r];
                    if (total < 0) l += 1;
                    else if (total > 0) r -= 1;
                    else
                    {
                        int[] triplets = new int[] { numsList[i], numsList[l], numsList[r] };
                        solution.Add(triplets);
                        while (l < r && triplets[1] == numsList[l])
                        {
                            l++;
                        }
                        while (l < r && triplets[2] == numsList[r])
                        {
                            r--;
                        }
                    }
                }
            }

            
            

            return solution;
        }



    }
}
