public class Solution {
    public int StrangePrinter(string s) {
        int n = s.Length;
        int[,] memo = new int[n, n];
        return MinTurns(s, 0, n - 1, memo);
    }

    private int MinTurns(string s, int i, int j, int[,] memo) {
        if (i > j) return 0; // Base case: empty substring
        if (memo[i, j] != 0) return memo[i, j]; // Return already computed value
        
        // Start with the assumption that we need to print all from s[i] to s[j] as one sequence
        int minTurns = MinTurns(s, i, j - 1, memo) + 1;

        // Try splitting at every k where s[k] == s[j]
        for (int k = i; k < j; k++) {
            if (s[k] == s[j]) {
                int turns = MinTurns(s, i, k, memo) + MinTurns(s, k + 1, j - 1, memo);
                minTurns = Math.Min(minTurns, turns);
            }
        }
        
        memo[i, j] = minTurns; // Store result in memoization table
        return minTurns;
    }
}