using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75
{
    public class Max_Number_of_K_Sum_Pairs
    {
        //https://leetcode.com/problems/max-number-of-k-sum-pairs/description/?envType=study-plan-v2&envId=leetcode-75

        public int MaxOperations(int[] nums, int k)
        {
            int count=0;
            Dictionary<int, int> x = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int searcher = k - nums[i];
                if (!x.ContainsKey(searcher) )
                {
                    x[nums[i]]=i;
                }
                else
                {
                    count++;
                    x.Remove(searcher);
                }

            }
            return count;

        }
    }
}
