public class Solution {
    public int NumberOfSubarrays(int[] nums, int k) {
        var res = 0;
        var prefixSum = 0;
        var dict = new Dictionary<int,int>();
        dict[0] = 1;
        for(int i = 0 ; i < nums.Length; i++)
        {
            prefixSum += ( nums[i] % 2 == 1) ? 1:0;
            if(dict.ContainsKey(prefixSum-k))
                res += dict[prefixSum-k];

            if(dict.ContainsKey(prefixSum))
                dict[prefixSum]++;
            else
                dict[prefixSum] = 1;
        }
        return res;
    }
}