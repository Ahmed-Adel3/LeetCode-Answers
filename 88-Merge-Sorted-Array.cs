public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
         for(int i = 0 ; i < nums2.Length; i ++){
            var index = Array.LastIndexOf(nums1,0);
            if(index == -1)
               nums1.Append(nums2[i]);
            else
               nums1[index] = nums2[i];
         }
         Array.Sort(nums1);
    }
}