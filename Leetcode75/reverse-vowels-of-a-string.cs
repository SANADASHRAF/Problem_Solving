using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Leetcode75
{
    public class reverse_vowels_of_a_string
    {
        public string ReverseVowels(string s)
        {
            //https://leetcode.com/problems/reverse-vowels-of-a-string/?envType=study-plan-v2&envId=leetcode-75
            if (string.IsNullOrEmpty(s)) 
                return s;
            var vowels = new HashSet<char>("aeiouAEIOU");
            var vowelspositions = new Dictionary<int, char>();
            for(int i = 0; i < s.Length; i++)
            {
                if(vowels.Contains(s[i]))
                    vowelspositions[i] = s[i];
                //  reverse      
            }
            var reverevowels = new List<char>(vowelspositions.Values);
            reverevowels.Reverse();
            var chararray = s.ToCharArray();
            int index = 0;
            foreach (var position in vowelspositions.Keys)
            {
                chararray[position] = reverevowels[index];
                index++;
            }
            return new string(chararray);
        }
    }
}
