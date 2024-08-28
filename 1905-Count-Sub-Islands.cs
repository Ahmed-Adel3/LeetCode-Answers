public class Solution {
    public int CountSubIslands(int[][] grid1, int[][] grid2) {
        int rows = grid1.Length;
        int cols = grid1[0].Length;
        HashSet<(int, int)> visit = new HashSet<(int, int)>();

        bool Dfs(int r, int c) {
            if (r < 0 || c < 0 || r >= rows || c >= cols || grid2[r][c] == 0 || visit.Contains((r, c))) {
                return true;
            }

            visit.Add((r, c));
            bool res = true;

            if (grid1[r][c] == 0) {
                res = false;
            }

            res = Dfs(r - 1, c) && res;
            res = Dfs(r + 1, c) && res;
            res = Dfs(r, c - 1) && res;
            res = Dfs(r, c + 1) && res;

            return res;
        }

        int count = 0;
        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                if (grid2[r][c] == 1 && !visit.Contains((r, c)) && Dfs(r, c)) {
                    count++;
                }
            }
        }

        return count;
    }
}