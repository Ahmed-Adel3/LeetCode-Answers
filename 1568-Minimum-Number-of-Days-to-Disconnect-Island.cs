public class Solution {
    public int MinDays(int[][] grid) {
        // Step 1: Check if the grid is already disconnected.
        if (CountIslands(grid) != 1) {
            return 0;
        }

        // Step 2: Check for bridge-like cells.
        int rows = grid.Length;
        int cols = grid[0].Length;

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (grid[i][j] == 1) {
                    // Remove this land temporarily
                    grid[i][j] = 0;
                    if (CountIslands(grid) != 1) {
                        return 1;
                    }
                    // Restore the land
                    grid[i][j] = 1;
                }
            }
        }

        // Step 3: If no bridge-like cell exists, return 2.
        return 2;
    }

    private int CountIslands(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        bool[,] visited = new bool[rows, cols];
        int islandCount = 0;

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (grid[i][j] == 1 && !visited[i, j]) {
                    islandCount++;
                    DFS(grid, visited, i, j);
                }
            }
        }

        return islandCount;
    }

    private void DFS(int[][] grid, bool[,] visited, int i, int j) {
        int[] dx = {-1, 1, 0, 0};
        int[] dy = {0, 0, -1, 1};

        visited[i, j] = true;

        for (int k = 0; k < 4; k++) {
            int newX = i + dx[k];
            int newY = j + dy[k];

            if (newX >= 0 && newX < grid.Length && newY >= 0 && newY < grid[0].Length &&
                grid[newX][newY] == 1 && !visited[newX, newY]) {
                DFS(grid, visited, newX, newY);
            }
        }
    }
}