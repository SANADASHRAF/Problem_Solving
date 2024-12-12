using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode75
{
    public class can_place_flowers
    {
        //https://leetcode.com/problems/can-place-flowers/?envType=study-plan-v2&envId=leetcode-75
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = 0;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0 &&
                    (i == 0 || flowerbed[i - 1] == 0) &&
                    (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
                {
                    flowerbed[i] = 1; // Mark the position as occupied
                    count++;
                }

                if (count >= n)
                    return true;
            }
            return false;
        }

    }
}
