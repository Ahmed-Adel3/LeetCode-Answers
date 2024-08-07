public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rowLen = matrix[0].Length;
        int top = 0 ; int bottom = matrix.Length-1;
        int rowIndex = -1;
        while(top <= bottom)
        {
            var mid = top + (bottom-top)/2;
            if(matrix[mid][0] > target)
                bottom = mid - 1;
            else if(matrix[mid][rowLen-1] < target)
                top = mid + 1;
            else {
                rowIndex = mid; 
                break;
            }
        }
        
        if(rowIndex == -1) return false;

        int left = 0, right = rowLen-1;
        while(left <= right)
        {
            int mid = left + (right-left)/2;
            if(matrix[rowIndex][mid] < target)
                left = mid +1;
            else if(matrix[rowIndex][mid] > target)
                right = mid-1;
            else 
                return true;
        }
        return false;
    }
}