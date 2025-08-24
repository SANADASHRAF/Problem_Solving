using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Separate_the_Digits_in_an_Array_3
    {

        // https://leetcode.com/problems/separate-the-digits-in-an-array/
        public int[] SeparateDigits(int[] nums)
        {
            List<int> result = new List<int>();

            foreach (int num in nums)
            {
                AddDigitsRecursive(num, result);
            }

            return result.ToArray();
        }

        private void AddDigitsRecursive(int n, List<int> result)
        {
            if (n < 10)
            {
                result.Add(n);
                return;
            }

            AddDigitsRecursive(n / 10, result);
            result.Add(n % 10);                 
        }


    }
}
