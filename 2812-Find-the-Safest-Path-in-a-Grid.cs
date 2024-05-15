public class Solution {
    // Directions for moving to neighboring cells: right, left, down, up
    int[][] dir = { new int[]{0, 1}, new int[]{0, -1}, new int[]{1, 0}, new int[]{-1, 0} };

    public int MaximumSafenessFactor(IList<IList<int>> grid) {
        int n = grid.Count;
        int[,] mat = new int[n, n];
        Queue<int[]> multiSourceQueue = new Queue<int[]>();

        // To make modifications and navigation easier, the grid is converted into a 2-d array.
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] == 1) {
                    // Push thief coordinates to the queue
                    multiSourceQueue.Enqueue(new int[]{i, j});
                    // Mark thief cell with 0
                    mat[i, j] = 0;
                } else {
                    // Mark empty cell with -1
                    mat[i, j] = -1;
                }
            }
        }

        // Calculate safeness factor for each cell using BFS
        while (multiSourceQueue.Count > 0) {
            int size = multiSourceQueue.Count;
            while (size-- > 0) {
                int[] curr = multiSourceQueue.Dequeue();
                // Check neighboring cells
                foreach (var d in dir) {
                    int di = curr[0] + d[0];
                    int dj = curr[1] + d[1];
                    int val = mat[curr[0], curr[1]];
                    // Check if the neighboring cell is valid and unvisited
                    if (IsValidCell(mat, di, dj) && mat[di, dj] == -1) {
                        // Update safeness factor and push to the queue
                        mat[di, dj] = val + 1;
                        multiSourceQueue.Enqueue(new int[]{di, dj});
                    }
                }
            }
        }

        // Binary search for maximum safeness factor
        int start = 0;
        int end = 0;
        int res = -1;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                // Set end as the maximum safeness factor possible
                end = Math.Max(end, mat[i, j]);
            }
        }

        while (start <= end) {
            int mid = start + (end - start) / 2;
            if (IsValidSafeness(mat, mid)) {
                // Store valid safeness and search for larger ones 
                res = mid; 
                start = mid + 1;
            } else {
                end = mid - 1;
            }
        }
        return res;
    }

    // Check if a path exists with given minimum safeness value
    private bool IsValidSafeness(int[,] grid, int minSafeness) {
        int n = grid.GetLength(0);

        // Check if the source and destination cells satisfy minimum safeness
        if (grid[0, 0] < minSafeness || grid[n - 1, n - 1] < minSafeness) {
            return false;
        }

        Queue<int[]> traversalQueue = new Queue<int[]>();
        traversalQueue.Enqueue(new int[]{0, 0});
        bool[,] visited = new bool[n, n];
        visited[0, 0] = true;

        // Breadth-first search to find a valid path
        while (traversalQueue.Count > 0) {
            int[] curr = traversalQueue.Dequeue();
            if (curr[0] == n - 1 && curr[1] == n - 1) {
                return true; // Valid path found
            }
            // Check neighboring cells
            foreach (var d in dir) {
                int di = curr[0] + d[0];
                int dj = curr[1] + d[1];
                // Check if the neighboring cell is valid, unvisited and satisfying minimum safeness
                if (IsValidCell(grid, di, dj) && !visited[di, dj] && grid[di, dj] >= minSafeness) {
                    visited[di, dj] = true;
                    traversalQueue.Enqueue(new int[]{di, dj});
                }
            }
        }

        return false; // No valid path found
    }

    // Check if a given cell lies within the grid
    private bool IsValidCell(int[,] mat, int i, int j) {
        int n = mat.GetLength(0);
        return i >= 0 && j >= 0 && i < n && j < n;
    }
}