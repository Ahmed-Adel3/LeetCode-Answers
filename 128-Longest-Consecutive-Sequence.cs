public class Solution {
    public int LongestConsecutive(int[] nums) {
        var hash = new HashSet<int>(nums);
        int max = 0;
        for(int i = 0 ; i < nums.Length ; i++)
        {
            if(!hash.Contains(nums[i]-1))
            {
                var counter = 1;
                while(hash.Contains(nums[i]+counter))
                {
                    counter++;
                }
                max = Math.Max(counter,max);
            }
        }
        return max;
    }
}