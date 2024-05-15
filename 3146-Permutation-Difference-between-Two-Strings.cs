public class Solution {
    public int FindPermutationDifference(string s, string t) {
        int n = s.Length;
        int result = 0;
        for (int i = 0; i < n; i++) {
            int indexS = s.IndexOf(t[i]);
            result += Math.Abs(indexS - i);
        }
        return result;
    }
}