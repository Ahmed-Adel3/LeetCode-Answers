public class Solution {
    public int SmallestDistancePair(int[] nums, int k) {
        Array.Sort(nums);
        int low = 0;
        int high = nums[nums.Length - 1] - nums[0];

        while (low < high) {
            int mid = low + (high - low) / 2;
            if (CountPairs(nums, mid) >= k) {
                high = mid;
            } else {
                low = mid + 1;
            }
        }

        return low;
    }

    private int CountPairs(int[] nums, int mid) {
        int count = 0;
        int j = 0;

        for (int i = 0; i < nums.Length; i++) {
            while (j < nums.Length && nums[j] - nums[i] <= mid) {
                j++;
            }
            count += j - i - 1;
        }

        return count;
    }
}