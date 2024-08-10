public class Solution {
    public int RegionsBySlashes(string[] grid) {
        int n = grid.Length;
        int size = n * 3;
        int[,] expandedGrid = new int[size, size];

        // Expand grid by filling the expandedGrid based on the slashes in the original grid
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                char c = grid[i][j];
                int r = i * 3;
                int c1 = j * 3;
                if (c == '/') {
                    expandedGrid[r, c1 + 2] = 1;
                    expandedGrid[r + 1, c1 + 1] = 1;
                    expandedGrid[r + 2, c1] = 1;
                } else if (c == '\\') {
                    expandedGrid[r, c1] = 1;
                    expandedGrid[r + 1, c1 + 1] = 1;
                    expandedGrid[r + 2, c1 + 2] = 1;
                }
            }
        }

        // Count regions using DFS
        int regions = 0;
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                if (expandedGrid[i, j] == 0) {
                    regions++;
                    DFS(expandedGrid, i, j, size);
                }
            }
        }

        return regions;
    }

    private void DFS(int[,] grid, int r, int c, int size) {
        if (r < 0 || r >= size || c < 0 || c >= size || grid[r, c] != 0) {
            return;
        }

        grid[r, c] = 1; // Mark the cell as visited

        // Visit all 4 adjacent cells
        DFS(grid, r - 1, c, size);
        DFS(grid, r + 1, c, size);
        DFS(grid, r, c - 1, size);
        DFS(grid, r, c + 1, size);
    }
}