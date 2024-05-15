public class Solution {
    public int MajorityElement(int[] nums) {
        int cur = nums[0];
        int occ = 1;

        for(int i = 1 ; i < nums.Length ; i++)
        {
            if(occ == 0)
                cur = nums[i];
            if(nums[i] == cur)
                occ++;
            else
                occ--;
        }
        return cur;
    }
}