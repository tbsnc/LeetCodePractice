using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetTest.KataTraining
{
    public class SumOfIntervals
    {
        public SumOfIntervals()
        {
            SumIntervals(new (int, int)[] { (4, 4), (6, 6), (8, 8) });
        }

        /// <summary>
        /// rite a function called sumIntervals/sum_intervals that accepts an array of intervals, 
        /// and returns the sum of all the interval lengths. Overlapping intervals should only be counted once.
        ///Intervals
        ///Intervals are represented by a pair of integers in the form of an array.
        ///The first value of the interval will always be less than the second value.Interval example: [1, 5] is an interval from 1 to 5. 
        ///The length of this interval is 4.
        ///[
        /// [1, 4],
        /// [7, 10],
        /// [3, 5]
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>

        public static int SumIntervals((int, int)[] intervals)
        {
            //enumerating intervals takes too long, min and max calculations should prolly be used
            List<int[]> intervalList = new List<int[]>();
            List<int[]> solutionList = new List<int[]>();   
            bool removeTemp=false;
            foreach (var item in intervals)
            {
                intervalList.Add(new int[] { item.Item1, item.Item2 });
            }

            while (intervalList.Count > 0)
            {
                var tempList = intervalList[0];
                intervalList.RemoveAt(0);
       
                for (int i = 0; i < intervalList.Count; i++)
                {
                    if ((tempList.Max() < intervalList[i].Min()) || (tempList.Min() > intervalList[i].Max()))
                    {
                        removeTemp = false;
                    }
                    else
                    {
                        var start = tempList.Min() < intervalList[i].Min() ? tempList.Min() : intervalList[i].Min();
                        var end = tempList.Max() > intervalList[i].Max() ? tempList.Max() : intervalList[i].Max();

                        intervalList.RemoveAt(i);
                        intervalList.Add(new int[] { start, end });
                        if(intervalList.Count == 1) solutionList.Add(intervalList[0]);
                        removeTemp = true;
                    }
                  
                }
                if(!removeTemp) 
                {
                    solutionList.Add(tempList);
                }
            }



            int sum = 0;

            foreach (var item in solutionList)
            {
                sum += item[1] - item[0]; 
            }
            return sum;
        }
    }
}
