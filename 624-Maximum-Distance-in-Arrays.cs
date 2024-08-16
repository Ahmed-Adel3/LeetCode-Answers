public class Solution {
    public int MaxDistance(IList<IList<int>> arrays) {
        int res = 0;
        int min = arrays[0][0];
        int max = arrays[0][arrays[0].Count - 1];

        // Loop to find min and max excluding current array
        for (int i = 1; i < arrays.Count; i++) {
            int currentMin = arrays[i][0];
            int currentMax = arrays[i][arrays[i].Count - 1];
            res = Math.Max(res, Math.Abs(currentMax - min));
            res = Math.Max(res, Math.Abs(max - currentMin));

            // Update global min and max
            min = Math.Min(min, currentMin);
            max = Math.Max(max, currentMax);
        }

        return res;
    }
}