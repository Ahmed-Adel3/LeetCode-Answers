public class Solution {
    public int StoneGameII(int[] piles) {
        int n = piles.Length;
        int[,] memo = new int[n, n + 1];
        return DFS(piles, 0, 1, memo);
    }

    private int DFS(int[] piles, int i, int M, int[,] memo) {
        int n = piles.Length;
        if (i >= n) return 0;
        if (memo[i, M] > 0) return memo[i, M];

        int maxStones = 0;
        int sum = 0;
        for (int x = 1; x <= 2 * M && i + x <= n; x++) {
            sum += piles[i + x - 1];
            // The maximum Alice can get is the total stones left minus the best outcome Bob can force Alice into.
            maxStones = Math.Max(maxStones, sum + (sumTotal(piles, i + x) - DFS(piles, i + x, Math.Max(M, x), memo)));
        }

        memo[i, M] = maxStones;
        return maxStones;
    }

    private int sumTotal(int[] piles, int start) {
        int sum = 0;
        for (int i = start; i < piles.Length; i++) {
            sum += piles[i];
        }
        return sum;
    }
}