using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Maximum_Number_of_Pairs_in_Array
    {
        //https://leetcode.com/problems/minimum-sum-of-four-digit-number-after-splitting-digits/
        public int[] NumberOfPairs(int[] nums)
        {
            Dictionary<int, int> countMap = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (countMap.ContainsKey(num))
                {
                    countMap[num]++;
                }
                else
                {
                    countMap[num] = 1;
                }
            }
            int TotalPairs = 0;
            int LeftPairsCount = 0;
            foreach (var key in countMap.Keys.ToList())
            {

                TotalPairs += (countMap[key] / 2);
                LeftPairsCount += (countMap[key] % 2);

            }
            return new int[] { TotalPairs, LeftPairsCount };
        }
    }
}
