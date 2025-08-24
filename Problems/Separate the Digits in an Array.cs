using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Separate_the_Digits_in_an_Array
    {
        https://leetcode.com/problems/separate-the-digits-in-an-array/
        public int[] SeparateDigits(int[] nums)
        {
            List<int> result = new List<int>();

            foreach (int num in nums)
            {

                foreach (char c in num.ToString())
                {
                    result.Add(c - '0');
                }
            }

            return result.ToArray();
        }

      

    }
}
