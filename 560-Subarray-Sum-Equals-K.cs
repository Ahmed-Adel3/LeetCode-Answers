public class Solution {
    public int SubarraySum(int[] nums, int k) {
        var dict = new Dictionary<int,int>();
        dict.Add(0,1);
        var sum = 0;
        var res = 0;

        foreach(int i in nums)
        {
            sum += i;
            var remain = sum - k;
            if(!dict.ContainsKey(remain))
                dict.Add(remain,0);
            
            res += dict[remain];

            if(!dict.ContainsKey(sum))
                dict.Add(sum,1);
            else
                dict[sum] +=1;
        }

        return res;
    }
}