using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75
{
    public class move_zeroes
    {
        //https://leetcode.com/problems/move-zeroes/description/?envType=study-plan-v2&envId=leetcode-75
        public void MoveZeroes(int[] nums)
        {
            int nonindexelement = 0;
            for(int i = 0 ; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    nums[nonindexelement] = nums[i];
                    nonindexelement++;
                }
            }
            for(int i = nonindexelement ; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
