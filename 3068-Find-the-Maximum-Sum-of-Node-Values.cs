public class Solution {
    public long MaximumValueSum(int[] nums, int k, int[][] edges) {
        long sum = 0;
        long minExtra = 1000000; 
        int count = 0;

        foreach (int val in nums) {
            if ((val ^ k) > val) {
                sum += val ^ k;
                minExtra = Math.Min(minExtra, (val ^ k) - val);
                count++;
            } else {
                sum += val;
                minExtra = Math.Min(minExtra, val - (val ^ k));
            }
        }

        return (count % 2 == 0) ? sum : sum - minExtra;
    }
}