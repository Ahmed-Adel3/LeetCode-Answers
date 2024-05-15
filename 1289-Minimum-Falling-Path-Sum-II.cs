public class Solution {
    public int MinFallingPathSum(int[][] grid) {
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
        int r = grid.Length;
        int c = grid.Length;
        for(int i=0;i<c;i++){
            minHeap.Enqueue(grid[0][i], grid[0][i]);
        }
        for(int i=1;i<r;i++){
            int min1 = minHeap.Dequeue();
            int min2 = minHeap.Dequeue();
            minHeap.Clear();
            for(int j=0;j<c;j++){
               if(grid[i-1][j] == min1){
                   grid[i][j] += min2;
               }
               else{
                    grid[i][j] += min1;
               }
               minHeap.Enqueue(grid[i][j],grid[i][j]);
            }
        }

        return minHeap.Peek();    
    }
}