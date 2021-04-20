using System;
using System.Collections.Generic;
using System.Text;

namespace Walmart
{
    public class CoinChange
    {
        public static int CoinChanger(int[] coins, int amount)
        {

            if (coins == null || coins.Length == 0)
                return 0;
            // this array each position indicates we are trying for that amount
            int[] dp = new int[amount + 1];
            // fill the array with max value 
            Array.Fill(dp, amount + 1);
            //no of coins required to make $0 
            dp[0] = 0;

            // this loop fills the dp array 
            for (int i = 0; i < dp.Length; i++)
            {
                // check all the coins
                for (int j = 0; j < coins.Length; j++)
                {
                    //current coin is less than or equal to dp position
                    // suppose if we are filling for dp[3] and if coins[j] = 2
                    // we are trying to fill min of dp[3] or 1 + dp[1] 
                    if (coins[j] <= i)
                    {                   //      1 + the sub problem we solve minus the coin we just added onto    
                        dp[i] = Math.Min(dp[i], 1 + dp[i - coins[j]]);
                    }
                }
            }

            return ((dp[amount] > amount) ? -1 : dp[amount]);
        }
    }
}
