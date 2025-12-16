using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Problems
{
    public class FindMedianSortedArrayss
    {
        //https://leetcode.com/problems/median-of-two-sorted-arrays/description/
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int n1 = nums1.Length;
            int n2 = nums2.Length;
            int [] merged =nums1.Concat(nums2).OrderBy(x=>x).ToArray();

            int totalLength = merged.Length;

            if(totalLength % 2 ==0)
            {
                return (merged[totalLength / 2] + merged[(totalLength / 2) - 1]) / 2.0;
            }
            else
            {
                return merged[totalLength / 2];
            }
        }
    }
}
