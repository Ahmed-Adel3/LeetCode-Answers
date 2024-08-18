public class Solution {
    public int NthUglyNumber(int n) {
        List<int> nums = new List<int> { 1 };
        int i2 = 0, i3 = 0, i5 = 0;

        for (int i = 1; i < n; i++)
        {
            int nextNum = Math.Min(nums[i2] * 2, Math.Min(nums[i3] * 3, nums[i5] * 5));
            nums.Add(nextNum);

            if (nextNum == nums[i2] * 2)  i2++;
            
            if (nextNum == nums[i3] * 3)  i3++;

            if (nextNum == nums[i5] * 5)  i5++;
        }

        return nums[n - 1];
    }
}