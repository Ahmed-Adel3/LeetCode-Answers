public class Solution {
 public int BeautifulSubsets(int[] nums, int k) {
        return Helper(0, nums, k, new Dictionary<int, int>()) -1;
    }

    private int Helper(int i, int[] nums, int k, Dictionary<int, int> count) {
        if (i == nums.Length) {
            return 1;
        }

        int res = Helper(i + 1, nums, k, count);  // skip nums[i]

        if (!count.ContainsKey(nums[i] + k) || count[nums[i] + k] == 0) {
            if (!count.ContainsKey(nums[i] - k) || count[nums[i] - k] == 0) {
                // include nums[i]
                if (!count.ContainsKey(nums[i])) {
                    count[nums[i]] = 0;
                }
                count[nums[i]]++;
                res += Helper(i + 1, nums, k, count);
                count[nums[i]]--;
            }
        }

        return res;
    }
}