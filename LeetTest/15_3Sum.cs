using System;
using System.Collections.Generic;
using System.Linq;


namespace LeetTest
{
    internal class _15_3Sum 
    {
        public _15_3Sum(int[] nums)
        {
            // ThreeSum(nums);
            ThreeSumClosestMuchFaster(new int[] { -1, 2, 1, -4 }, 1);
            ThreeSumClosestMuchFaster(new int[] { 833, 736, 953, -584, -448, 207, 128, -445, 126, 248, 871, 860, 333, -899, 463, 488, -50, -331, 903, 575, 265, 162, -733, 648, 678, 549, 579, -172, -897, 562, -503, -508, 858, 259, -347, -162, -505, -694, 300, -40, -147, 383, -221, -28, -699, 36, -229, 960, 317, -585, 879, 406, 2, 409, -393, -934, 67, 71, -312, 787, 161, 514, 865, 60, 555, 843, -725, -966, -352, 862, 821, 803, -835, -635, 476, -704, -78, 393, 212, 767, -833, 543, 923, -993, 274, -839, 389, 447, 741, 999, -87, 599, -349, -515, -553, -14, -421, -294, -204, -713, 497, 168, 337, -345, -948, 145, 625, 901, 34, -306, -546, -536, 332, -467, -729, 229, -170, -915, 407, 450, 159, -385, 163, -420, 58, 869, 308, -494, 367, -33, 205, -823, -869, 478, -238, -375, 352, 113, -741, -970, -990, 802, -173, -977, 464, -801, -408, -77, 694, -58, -796, -599, -918, 643, -651, -555, 864, -274, 534, 211, -910, 815, -102, 24, -461, -146 }, -7111);

        }


        public int ThreeSumClosestMuchFaster(int[] nums, int target)
        {
            Array.Sort(nums);

            int current;
            int solution = int.MaxValue;
       
            for (int i = 0; i < nums.Length-1; i++)
            {
               int l = i + 1;
               int  r = nums.Length - 1;

                while (l < r)
                {
                    current = nums[i] + nums[l] + nums[r];

                    if (current == target)
                    {
                        return current;
                    }
                    else if (current < target)
                    {
                        l++;
                    }
                    else { r--; }

                    if (Math.Abs(current - target) < Math.Abs(solution - target))
                    {
                        solution = current;
                    }
                }
            }
            return solution;
        }

        public int ThreeSumClosest(int[] nums, int target) //16 three sum closest 
        {
            Dictionary<int,int> dictOfSums = new Dictionary<int, int>();
            int l, r;
            int current = 0;
            int closest = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
            
                l = i + 1;
                r = nums.Length - 1;

                for (l = i + 1; l < nums.Length - 1; l++)
                {
                    while (l < r)
                    {
                        current = Math.Abs((nums[i] + nums[l] + nums[r]) - target);
                        
                        if (current < closest)
                        {
                            dictOfSums[current] = nums[i] + nums[l] + nums[r];
                        }
                        
                        r--;
                    }
                    r = nums.Length - 1;
                }

            }

           


            return dictOfSums[dictOfSums.Min(x => x.Key)];
            

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
