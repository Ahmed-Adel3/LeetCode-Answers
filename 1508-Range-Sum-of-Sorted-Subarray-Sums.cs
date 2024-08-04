public class Solution {
    public int RangeSum(int[] nums, int n, int left, int right) {
        var sums = new int[n*(n+1)/2];
        var index = 0;
        for(int i = 0 ; i < n ; i++)
        {
            var sum = 0;
            for(int j=i; j <n ;j++)
            {
                sum+= nums[j];
                sums[index++] = sum;
            }
        }
        Array.Sort(sums);
        long res = 0;
        for(int i = left-1 ; i < right ;i++)
            res+=sums[i];
        res = res%1000000007;
        return (int)res;
    }
}