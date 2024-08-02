public class Solution {
    public int MinSwaps(int[] nums) {
        var onesCount = nums.Count(a=>a == 1);
        var len = nums.Length;
        var onesWindow = 0;
        var maxOnesWindow = 0;
        var left = 0;

        for(int r = 0 ; r < 2*len;r++)
        {
            onesWindow += nums[r%len]; //increment if it equals one 
            if(r-left+1 > onesCount) {
                onesWindow-=nums[left%len]; //devrement if it equals one
                left++;
            }
            maxOnesWindow = Math.Max(maxOnesWindow,onesWindow);
        }
        return onesCount - maxOnesWindow;
    }
}