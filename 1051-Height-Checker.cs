public class Solution {
    public int HeightChecker(int[] heights) {
        var res = 0;
        var sorted = new int[heights.Length];
        heights.CopyTo(sorted,0);
        Array.Sort(sorted);
        for (int i = 0 ; i < heights.Length ; i ++)
        {
            if(heights[i] != sorted[i])
            {
                res ++;
            }
        }
        return res;
    }
}