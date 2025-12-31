using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Remove_Duplicates_from_Sorted_Array
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int notrepeatIndex = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[notrepeatIndex])
                {
                    notrepeatIndex++;
                    nums[notrepeatIndex] = nums[i];
                }
            }
            return notrepeatIndex + 1;
        }
    }
}
