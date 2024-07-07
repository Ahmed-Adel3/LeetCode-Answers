public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        var res = 0;
        var empty = 0;

        while(numBottles > 0) 
        {
            res += numBottles;
            empty += numBottles;
            numBottles = empty / numExchange;
            empty = empty%numExchange;
        }
        return res;
    }
}