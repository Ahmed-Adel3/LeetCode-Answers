public class Solution {
    public int MinDifference(int[] nums) {
        if(nums.Length <= 4)
            return 0;

        Array.Sort(nums);
        var min = int.MaxValue;
        for(int i = 0 ; i < 4 ; i++)
        {
            min = Math.Min(min,nums[nums.Length-4+i] - nums[i]);
        }
        return min;
    }
}