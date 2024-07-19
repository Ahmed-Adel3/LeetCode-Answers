public class Solution {
    public IList<int> LuckyNumbers (int[][] matrix) {
        int ROWS = matrix.Length;
        int COLS = matrix[0].Length;

        float maxOfRowMins = float.NegativeInfinity;
        for (int r = 0; r < ROWS; r++) {
            int rowMin = matrix[r].Min();
            maxOfRowMins = Math.Max(rowMin, maxOfRowMins);
        }

        for (int c = 0; c < COLS; c++) {
            int colMax = matrix[0][c];
            for (int r = 0; r < ROWS; r++) {
                colMax = Math.Max(colMax, matrix[r][c]);
            }
            if (colMax == maxOfRowMins) {
                return new List<int> { colMax };
            }
        }

        return new List<int>(); 
    }
}