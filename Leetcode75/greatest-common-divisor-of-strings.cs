using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75
{
    public class greatest_common_divisor_of_strings
    {
        //https://leetcode.com/problems/greatest-common-divisor-of-strings/?envType=study-plan-v2&envId=leetcode-75
        public int gcd(int a, int b)
        {
            // lengthOfString1 , lengthOfString2   
            // a is more length  
            while(b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public string GcdOfStrings(string str1, string str2)
        {
            // دلوقتى ع يكون فية عامل مشترك بين الاتنين لازم جمع الاتنين بداية من اى واحد يكونو بيدو نفس النتيجة لو مش زى بعض يبقى مفيش 
            if((str1 + str2) != (str2 + str1))
                return "";
            int GetGcd = gcd(str1.Length , str2.Length);
            return str1.Substring(0, GetGcd);
        }
        
    }
}
