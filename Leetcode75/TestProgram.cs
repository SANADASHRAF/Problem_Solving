using System;

namespace Leetcode75
{
    public class TestProgram
    {
        static void Main(string[] args)
        {

            //MergeStringAlternately p1= new MergeStringAlternately();
            //greatest_common_divisor_of_strings x=new greatest_common_divisor_of_strings();
            //Console.WriteLine( x.GcdOfStrings("ABCABC", "ABC") );
            
            
            kids_with_the_greatest_number_of_candies x =new kids_with_the_greatest_number_of_candies();
            int[] candies = { 2, 3, 5, 1, 3 };
            int extraCandies = 3;
            IList<bool> output = x.KidsWithCandies(candies, extraCandies);
            Console.WriteLine(string.Join(", ", output));
            
        }
    }
}