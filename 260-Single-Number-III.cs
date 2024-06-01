public class Solution {
    public int[] SingleNumber(int[] nums) {
        if(nums.Length == 2)
                return nums;
        var res = new int?[2];
        Array.Sort(nums);
        for(int i = 0 ; i < nums.Length ; i++)
        {
            if(i == nums.Length-1){
                res[1] = nums[i];
                break;
            }
            if(nums[i] != nums[i+1])
            {
                if(res[0] == null)
                {
                    res[0] = nums[i];
                }
                else{
                    res[1] = nums[i];
                    break;
                }
            }
            else 
                i++;
        }
        return res.Cast<int>().ToArray();
    }
}