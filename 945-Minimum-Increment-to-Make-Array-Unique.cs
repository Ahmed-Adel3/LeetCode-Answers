public class Solution {
    public int MinIncrementForUnique(int[] nums) {
        var res = 0;
        var max = nums.Max() + nums.Length;
        var occ = new int[max];
        foreach (var num in nums) {
            occ[num]++;
        }
        
        for (int i = 0; i < max; i++) {
            if (occ[i] > 1) {
                int extra = occ[i] - 1;
                res += extra;
                occ[i + 1] += extra;
                occ[i] = 1;
            }
        }
        
        return res;
    }
}
