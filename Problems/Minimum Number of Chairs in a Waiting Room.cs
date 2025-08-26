using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Minimum_Number_of_Chairs_in_a_Waiting_Room
    {
        //https://leetcode.com/problems/minimum-number-of-chairs-in-a-waiting-room/description/
        public int MinimumChairs(string s)
        {
            int max = 0, count = 0;
            foreach (var c in s)
            {
                if (c == 'E')
                {
                    count++;
                    max = Math.Max(max, count);
                }
                else if (c == 'L')
                {
                    count--;
                }
            }
            return max;
        }

        
    }
}
