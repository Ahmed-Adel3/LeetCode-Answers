public class Solution {
    public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart) {
                int[][] directions = new int[][] {
            new int[] {0, 1},  // right
            new int[] {1, 0},  // down
            new int[] {0, -1}, // left
            new int[] {-1, 0}  // up
        };

        List<int[]> res = new List<int[]>();
        int r = rStart, c = cStart;
        int steps = 1;
        int i = 0;

        while (res.Count < rows * cols) {
            for (int j = 0; j < 2; j++) {
                int dr = directions[i][0], dc = directions[i][1];
                for (int k = 0; k < steps; k++) {
                    if (r >= 0 && r < rows && c >= 0 && c < cols) {
                        res.Add(new int[] { r, c });
                    }
                    r += dr;
                    c += dc;
                }
                i = (i + 1) % 4;
            }
            steps++;
        }

        return res.ToArray();
    }
}