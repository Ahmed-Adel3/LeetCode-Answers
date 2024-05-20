public class Solution {
    public int SubsetXORSum(int[] nums) {
        return Helper(nums, 0, 0);
    }

    private int Helper(int[] nums, int index, int currValue) {
        if (index == nums.Length) 
            return currValue;
        return Helper(nums, index + 1, currValue ^ nums[index]) + Helper(nums, index + 1, currValue);
    }
}