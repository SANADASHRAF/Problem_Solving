using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Longest_Substring_Without_Repeating_Characters
    {
        //https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
        public int LengthOfLongestSubstring(string s)
        {
            int count = 0, loopcount = 0;

            var map = new Dictionary<char, int>();
            Queue<char> window = new Queue<char>();

            foreach (char c in s)
            {
                while (map.ContainsKey(c))
                {
                    char removed = window.Dequeue();
                    map.Remove(removed);
                    loopcount--;
                }

                window.Enqueue(c);
                map[c] = 1;
                loopcount++;

                count = Math.Max(count, loopcount);
            }

            return count;
        }
    }
}
