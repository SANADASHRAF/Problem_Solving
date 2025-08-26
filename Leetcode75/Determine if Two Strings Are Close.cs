using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75
{
    public class Determine_if_Two_Strings_Are_Close
    {
        //https://leetcode.com/problems/determine-if-two-strings-are-close/description/?envType=study-plan-v2&envId=leetcode-75
        public bool CloseStrings(string word1, string word2)
        { // abbzzca   // babzzcz
            Dictionary<char, int> dict1 = new Dictionary<char, int>();
            if (word2.Length != word1.Length)
                return false;

            for (int i=0;i<word1.Length;i++)
            {
                if (dict1.ContainsKey(word1[i]))
                    dict1[word1[i]]++;
                else
                    dict1[word1[i]] = 1;
            }// a 2 b 2 c 1 z 2
            Dictionary<char, int> dict2 = new Dictionary<char, int>();
            for (int i = 0; i < word2.Length; i++)
            {
                if (dict2.ContainsKey(word2[i]))
                    dict2[word2[i]]++;
                else
                    dict2[word2[i]] = 1;
            } // a 1 b 2 c 1 z 2
           
            foreach (var item in dict1)
            {
                if (!dict2.ContainsKey(item.Key))
                    return false;     
            }

            var freq1 = dict1.Values.OrderBy(x => x).ToList();
            var freq2 = dict2.Values.OrderBy(x => x).ToList();

            if (!freq1.SequenceEqual(freq2))
                return false;

            return true;
        }
    }
}
