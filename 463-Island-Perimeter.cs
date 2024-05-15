public class Solution {
    public int IslandPerimeter(int[][] grid) {
        var count = 0;
        for(int i = 0 ; i < grid.Length ; i++)
        {
            for(int j = 0 ; j < grid[i].Length ; j++)
            {
                if(grid[i][j] == 1)
                {
                   //check up
                   if(i == 0 || grid[i-1][j] == 0)
                      count++;
                   //check down
                   if(i == grid.Length -1 || grid[i+1][j] == 0)
                      count++;
                   //check left
                   if(j == 0 || grid[i][j-1] == 0)
                      count++;
                   //check right
                   if(j == grid[i].Length -1 || grid[i][j+1] == 0)
                      count++;
                }
            }
        }
        return count;
    }
}