public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        Dictionary<int, int> remainder = new Dictionary<int, int>();
        remainder[0] = -1;
        int total = 0;
        for (int i = 0; i < nums.Length; i++) {
            total += nums[i];
            int r = total % k;
            if (!remainder.ContainsKey(r)) {
                remainder[r] = i;
            } else if (i - remainder[r] > 1) {
                return true;
            }
        }
        return false;
    }
}