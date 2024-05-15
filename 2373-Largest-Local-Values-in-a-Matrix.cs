public class Solution {
    public int[][] LargestLocal(int[][] grid) {
        var res = new int[grid.Length-2][];

        for(int i = 0 ; i < grid.Length-2 ; i++)
        {
            res[i] = new int[grid.Length-2];
            for(int j = 0 ; j < grid.Length-2 ; j++)
            {
                res[i][j] = GetMax(grid,i,j);
            }
        }
        return res;
    }

    public int GetMax(int[][] grid, int i, int j)
    {
        return new int[] {
            grid[i][j]   , grid[i][j+1]   , grid[i][j+2]   ,
            grid[i+1][j] , grid[i+1][j+1] , grid[i+1][j+2] ,
            grid[i+2][j] , grid[i+2][j+1] , grid[i+2][j+2]
        }.Max();

    }
}