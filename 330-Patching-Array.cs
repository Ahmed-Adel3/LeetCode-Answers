public class Solution {
    public int MinPatches(int[] nums, int n) {
        int index = 0, res = 0;
        long end = 0;

        while(end < n)
        {
            if(index < nums.Length && nums[index] <= end + 1)
            {
                end += nums[index];
                index++;
            }
            else{
                res++;
                end = 2 * end + 1;
            }
        }
        return res;
    }
}