public class Solution {
    public bool SatisfiesConditions(int[][] grid) {
            int rows = grid.Length;
            int cols = grid[0].Length;
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    // Check if cell below exists and if it is equal
                    if (i < rows - 1 && grid[i][j] != grid[i + 1][j])
                        return false;
                    if (j < cols - 1 && grid[i][j] == grid[i][j + 1])
                        return false;
                }
            }

            return true;
    }
}