public class Solution {
    public int Search(int[] nums, int target) {
                var left = 0;
        var right = nums.Length-1;

        while(left <= right)
        {
            var mid = left + (right-left)/2;

            if(nums[mid] == target) 
                return mid;
                
            if(nums[left] <= nums[mid])
            {
                if(nums[mid] < target || nums[left] > target)
                    left = mid + 1;
                else
                    right = mid-1;
            } else {
                if(nums[mid] > target || nums[right] < target)
                    right = mid-1;
                else
                    left = mid + 1;
            }
        }
        return -1;
    }
}