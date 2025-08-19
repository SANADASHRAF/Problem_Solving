using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Determine_if_String_Halves_Are_Alike
    {
        //https://leetcode.com/problems/determine-if-string-halves-are-alike/description/
        public bool HalvesAreAlike(string s)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int RCount = 0, LCount = 0;

            s =s.ToLower();

            int n = s.Length / 2;

            for (int i = 0; i < n; i++)
            {
                if (vowels.Contains(s[i]) )
                {
                    RCount++;
                }
                if (vowels.Contains(s[i + n]))
                {
                    LCount++;
                }
            }
            return (RCount == LCount) ? true : false;

            }
    }
}
