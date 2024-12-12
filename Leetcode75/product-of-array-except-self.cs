using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75
{
    public class product_of_array_except_self
    {
        //https://leetcode.com/problems/product-of-array-except-self/description/?envType=study-plan-v2&envId=leetcode-75
        public int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];

            int prefix = 1;
            for (int i = 0; i < n; i++)
            {
                result[i] = prefix;
                prefix *= nums[i];
            }

            int suffix = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                result[i] *= suffix;
                suffix *= nums[i];
            }

            return result;
        }
    }
}
