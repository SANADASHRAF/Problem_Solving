using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75
{
    public class kids_with_the_greatest_number_of_candies
    {
        //https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/description/?envType=study-plan-v2&envId=leetcode-75
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int maxinarr = candies.Max();
            bool[] result = new bool[candies.Length];
            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= maxinarr)
                    result[i] = true;
                else
                    result[i] = false;
            }
            return result; 
        }
    }
}
