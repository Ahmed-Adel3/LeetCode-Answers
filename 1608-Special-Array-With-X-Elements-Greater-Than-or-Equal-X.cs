public class Solution {
    public int SpecialArray(int[] nums) {
        Array.Sort(nums);   
        if(nums.Length <= nums[0])
            return nums.Length;

        for(int i = 0; i < nums.Length-1; i++)
        {
            for(int j = nums[i]+1; j<=nums[i+1]; j++)
            {
                if( j == nums.Length-i-1 )
                    return j; 
            }
        }
        return -1;
    }
}