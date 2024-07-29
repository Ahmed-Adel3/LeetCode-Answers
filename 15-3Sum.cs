public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var res = new List<IList<int>>();
        for(int i = 0 ; i < nums.Length ; i++)
        {
            if(i > 0 && nums[i] == nums[i-1]) continue;

            var left = i+1;
            var right = nums.Length-1;
            while (left < right)
            {
                var sum = nums[i]+nums[left]+nums[right];
                if(sum == 0){
                    res.Add(new List<int>{nums[i],nums[left],nums[right]});
                    left++;
                    while(nums[left] == nums[left-1] && left < right)
                        left++;
                }
                else if(sum > 0)
                    right--;
                else
                    left++;
            }
        }
        return res;
    }
}