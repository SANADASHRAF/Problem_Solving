using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75
{
    public class MergeStringAlternately
    {
        //link "https://leetcode.com/problems/merge-strings-alternately/description/?envType=study-plan-v2&envId=leetcode-75"
        public string MergeAlternately(string word1, string word2)
        {
            int i = 0, j = 0;
            string concat = "";
            while (i < word1.Length || j < word2.Length)
            {
                if (i < word1.Length) concat += word1[i++];
                if (j < word2.Length) concat += word2[j++];
            }
            return concat;
        }
    }
}
