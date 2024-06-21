public class Solution {
    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes) {
        var windowDictLen = customers.Length+1-minutes;
        if(windowDictLen < 0)
            return customers[0];

        var totalCust = new int[windowDictLen];
        var happyCust = new int[windowDictLen];
        var largestDiff = 0;
        var largestDiffIndex = 0;

        var totalSum = 0;
        var happySum = 0;

        //initial window
        for(int i = 0 ; i < minutes; i++)
        {
            totalSum += customers[i];
            if(grumpy[i] == 0)
                happySum+= customers[i];
        }

        largestDiff = totalSum - happySum;
        totalCust[0] = totalSum;
        happyCust[0] = happySum;

        totalSum -= customers[0];
        if(grumpy[0] == 0)
            happySum -= customers[0];

        for(int i = 1 ; i < totalCust.Length ; i++)
        {
            totalSum += customers[ i + minutes - 1 ];
            if(grumpy[i+ minutes - 1] == 0)
                happySum += customers[i+ minutes - 1 ];

            if(largestDiff < totalSum - happySum)
            {
                largestDiff = totalSum - happySum;
                largestDiffIndex = i;
            }
            totalCust[i] = totalSum;
            happyCust[i] = happySum;

            totalSum -= customers[i];
            if(grumpy[i] == 0)
                happySum-= customers[i];
        }

        for(int i = largestDiffIndex ; i <= minutes-1+largestDiffIndex ; i++)
        {
            grumpy[i] = 0;
        }

        var res = 0;
        for(int i = 0 ; i < customers.Length ; i++)
        {
            if(grumpy[i] == 0)
                res += customers[i];
        }
        return res;
    }
}