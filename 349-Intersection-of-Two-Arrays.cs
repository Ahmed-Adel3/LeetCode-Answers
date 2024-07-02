public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var set = new HashSet<int>(nums1);
        var intersection = new HashSet<int>();

        foreach (int num in nums2) {
            if (set.Contains(num)) {
                intersection.Add(num);
            }
        }
        return intersection.ToArray();
    }
}