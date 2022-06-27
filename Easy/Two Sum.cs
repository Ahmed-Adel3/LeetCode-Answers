public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int,int>(); 
        for(int i = 0;i<nums.Length;i++)
        {         
            var val = nums[i];
            var min = target - val;
            if (dict.ContainsKey(val))
                return new int[]{i,dict[val]};
            if (!dict.ContainsKey(min))
                dict.Add(min,i);
        }    
        return null;
    }
}