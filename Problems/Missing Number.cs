using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Missing_Number
    {
        //https://leetcode.com/problems/missing-number/description/
        public int MissingNumber(int[] nums)
        {
            nums=nums.OrderBy(x => x).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i)
                    return i;
            }
            return nums.Length;
        }
    }
}
