using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75
{
    public class Find_the_Difference_of_Two_Arrays
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
          //https://leetcode.com/problems/find-the-difference-of-two-arrays/description/?envType=study-plan-v2&envId=leetcode-75
            Dictionary<int, int> dict1 = new Dictionary<int, int>();
            Dictionary<int, int> dict2 = new Dictionary<int, int>();
            int max = Math.Max(nums1.Length, nums2.Length);
            for (int i = 0; i < max; i++)
            {
                if (i < nums1.Length)
                {
                    if (!dict1.ContainsKey(nums1[i]))
                    {
                        dict1.Add(nums1[i], 1);
                    }
                }
                if (i < nums2.Length)
                {
                    if (!dict2.ContainsKey(nums2[i]))
                    {
                        dict2.Add(nums2[i], 1);
                    }
                }
            }
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            foreach (var item in dict1)
            {
                if (!dict2.ContainsKey(item.Key))
                {
                    list1.Add(item.Key);
                }
            }
            foreach (var item in dict2)
            {
                if (!dict1.ContainsKey(item.Key))
                {
                    list2.Add(item.Key);
                }
            }
            return new List<IList<int>> { list1, list2 };

        }
       
    }
}
