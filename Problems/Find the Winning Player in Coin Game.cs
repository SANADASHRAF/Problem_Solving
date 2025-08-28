using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Find_the_Winning_Player_in_Coin_Game
    {
        //https://leetcode.com/problems/find-the-winning-player-in-coin-game/
        public string WinningPlayer(int x, int y)
        {
            int count = -1;
            while(x>0 && y>=4)
            {
                x -= 1;
                y -= 4;
                count++;
            }
            if((count & 1) == 0)
            {
                return "Alice";
            }
            return "Bob";
        }

    }
}
