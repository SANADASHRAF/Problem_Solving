using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Separate_the_Digits_in_an_Array
    {
        public int[] SeparateDigits(int[] nums)
        {
            List<int> result = new List<int>();

            foreach (int num in nums)
            {
                List<int> Digits = new List<int>();

                int n = num;
                while (n > 0)
                {
                    int LastDigit = n % 10;
                    Digits.Add(LastDigit);
                    n /= 10;
                }
                Digits.Reverse();
                result.AddRange(Digits);
            }

            return result.ToArray();
        }
    }
}
