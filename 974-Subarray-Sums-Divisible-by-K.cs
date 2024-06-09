public class Solution {
    public int SubarraysDivByK(int[] nums, int k) {
        var dict = new Dictionary<int,int>();
        dict.Add(0,1); //init val for remain key of 0 and occ of 1
        var totalSum = 0;
        var res = 0;

        for(int i = 0 ; i < nums.Length ; i++)
        {
            totalSum += nums[i];
            //var remain = Math.Abs(totalSum) % k;
            var remain = totalSum - (int)Math.Floor((double)totalSum/k) * k;
            if(!dict.ContainsKey(remain))
                dict.Add(remain,0);

            res += dict[remain];
            dict[remain]++;
        }
        return res;
    }
}