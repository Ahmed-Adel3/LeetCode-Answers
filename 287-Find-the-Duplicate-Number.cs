public class Solution {
    public int FindDuplicate(int[] nums) {
        int index = 0 ;
        for(int i = 0 ; i < nums.Length ; i++)
        {
            index = Math.Abs(nums[i])-1;
            if(nums[index] < 0)
                return Math.Abs(nums[i]);
            else
                nums[index] = -1 * nums[index];
        }
        return 0;
    }
}