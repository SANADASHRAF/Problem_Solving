using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Leetcode75
{
    public class reverse_words_in_a_string
    {
        //https://leetcode.com/problems/reverse-words-in-a-string/description/?envType=study-plan-v2&envId=leetcode-75
        public string ReverseWords(string s)
        {
            string[] x = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(x);
            return string.Join(" ", x);
        }
    }
}
