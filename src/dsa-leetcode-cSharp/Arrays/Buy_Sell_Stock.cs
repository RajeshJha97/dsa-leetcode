/* 
Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
*/

namespace Arrays;

internal class Buy_Sell_Stock
{
    public static int ProfitOnStocks()
    {
        int[] prices = [7, 1, 5, 3, 6, 4];
        int ans = 0;
        int minPrice = prices[0];

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
                minPrice = prices[i];

            int profitOnTheDay = prices[i] - minPrice;

            if (profitOnTheDay > ans)
                ans = profitOnTheDay;
        }

        return ans;

    }
}
