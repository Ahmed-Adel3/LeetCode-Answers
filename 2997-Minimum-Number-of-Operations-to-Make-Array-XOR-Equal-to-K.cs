public class Solution {
    public int MinOperations(int[] nums, int k) {
        var num = nums[0];
        for(int i = 1 ; i < nums.Length; i++)
        {
            num ^= nums[i];
        }
        if(num == k)
            return 0;
        
        return GetMinSteps(num,k);
    }

    public static int GetMinSteps(int x, int y)
    {
        int steps = 0;
        for(int i = 0; i < 32 ;i++)
        {
            var xLSB = ((x >> i) & 1);
            var yLSB = ((y >> i) & 1);

            if(xLSB!=yLSB)
                steps++;
        }

        return steps;
    }
}