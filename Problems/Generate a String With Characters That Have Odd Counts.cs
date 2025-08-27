using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Generate_a_String_With_Characters_That_Have_Odd_Counts
    {
        //https://leetcode.com/problems/generate-a-string-with-characters-that-have-odd-counts/
        public string GenerateTheString(int n)
        {
            string result = "";
            if (n % 2 == 0)
            {
                result = new string('a', n - 1) + 'b';
            }
            else
            {
                result = new string('a', n);
            }
            return result;
        }
    }
}
