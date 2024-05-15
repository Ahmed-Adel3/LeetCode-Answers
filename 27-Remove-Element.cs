public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var count = 0;
        for(int i = 0 ; i < nums.Length ; i++){
            if(nums[i] != val){
                nums[count] = nums[i];
                count++;
            }
        }
        return count;
    }
}