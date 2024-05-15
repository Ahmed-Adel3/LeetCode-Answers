public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        var res = new List<int>(nums.Length);
        int index = 0 ;
        for(int i = 0 ; i < nums.Length ; i++)
        {
            index = Math.Abs(nums[i])-1;
            if(nums[index] < 0)
                res.Add(Math.Abs(nums[i]));
            else
                nums[index] = -1 * nums[index];
        }

        return res;
    }
}