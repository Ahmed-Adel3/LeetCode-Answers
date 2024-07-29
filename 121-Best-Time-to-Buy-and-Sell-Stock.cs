public class Solution {
    public int MaxProfit(int[] prices) {
        var min = prices[0];
        var res = 0;

        for(int i = 1 ; i < prices.Length ; i++)
        {
            min = Math.Min(min,prices[i]);
            res = Math.Max(res,prices[i]-min);
        }
        return res;
    }
}