using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75
{
    public class increasing_triplet_subsequence
    {
        //https://leetcode.com/problems/increasing-triplet-subsequence/description/?envType=study-plan-v2&envId=leetcode-75
        public bool IncreasingTriplet(int[] nums)
        {
            int first = int.MaxValue;
            int scond = int.MaxValue;
            foreach (var x in nums)
            {
                if(x <= first)
                   first = x;
                else if(x<= scond)
                   scond = x;
                else 
                    return true;
            }
            return false;
        }
    }
}
