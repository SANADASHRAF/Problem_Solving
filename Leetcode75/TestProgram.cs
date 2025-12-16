using System;
using Problems;

namespace Leetcode75
{
    public class TestProgram
    {
        static void Main(string[] args)
        {



            //MergeStringAlternately p1= new MergeStringAlternately();
            //greatest_common_divisor_of_strings x=new greatest_common_divisor_of_strings();
            //Console.WriteLine( x.GcdOfStrings("ABCABC", "ABC") );


            //kids_with_the_greatest_number_of_candies x =new kids_with_the_greatest_number_of_candies();
            //int[] candies = { 2, 3, 5, 1, 3 };
            //int extraCandies = 3;
            //IList<bool> output = x.KidsWithCandies(candies, extraCandies);
            //Console.WriteLine(string.Join(", ", output));

            //can_place_flowers x= new can_place_flowers();
            //Console.WriteLine(x.CanPlaceFlowers([1, 0, 0, 0, 1],1));
            //Max_Number_of_K_Sum_Pairs x = new Max_Number_of_K_Sum_Pairs();
            //x.MaxOperations(new int[] { 1, 2, 3, 4 }, 5);

            Longest_Substring_Without_Repeating_Characters x = new Longest_Substring_Without_Repeating_Characters();
            x.LengthOfLongestSubstring("dvdf");
            Console.Write(x.ToString());
        }
    }
}