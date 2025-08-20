using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Minimum_Sum_of_Four_Digit_Number_After_Splitting_Digits
    {
        //https://leetcode.com/problems/minimum-sum-of-four-digit-number-after-splitting-digits/description/
        public int MinimumSum(int num)
        {
            char[] nums = num.ToString().ToCharArray();
            Array.Sort(nums);
            string first = $"{nums[0]}{nums[2]}";
            string second = $"{nums[1]}{nums[3]}";
            return int.Parse(first) + int.Parse(second);

        }
    }
}
