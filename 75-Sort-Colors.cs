public class Solution {
    public void SortColors(int[] nums) {

        void swap (int i , int j)
        {
            if(i == j)
                return;
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        var left = 0;
        var right = nums.Length-1;
        var i = 0;
        while(i <= right)
        {
            if(nums[i] == 0)
            {
                swap(i,left);
                left++;
            }
            else if(nums[i] == 2)
            {
                swap(i,right);
                right--;
                i--;
            }
            i++;
        }
    }
}