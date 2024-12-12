using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75
{
    public class is_subsequence
    {
        //https://leetcode.com/problems/is-subsequence/description/?envType=study-plan-v2&envId=leetcode-75
        public bool IsSubsequence(string s, string t)
        {
            if(s=="") return true;
            int sindexincrement = 0;
            for(int i = 0 ;i < t.Length; i++)
            {
                if(sindexincrement < s.Length && s[sindexincrement] == t[i])
                {
                    sindexincrement++;
                    if(sindexincrement == s.Length)
                        return true;
                }
            }
            return false;
        }
    }
}
