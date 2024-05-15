public class Solution {
    public int MatrixScore(int[][] grid) {
        var rows = grid.Length;
        var cols = grid[0].Length;

        for(int i = 0 ; i < rows ;i++)
        {
            InvertRow(grid,i);
        }

        for(int i = 0 ; i < cols ;i++)
        {
            InvertCol(grid,i);               
        }

        var sum = 0d;
        for(int i = 0 ; i < rows ;i++)
        {
            var str = string.Join("",grid[i]);
            sum += Convert.ToInt32(str,2);
        }
        return (int)sum;
    }

    public void InvertRow(int[][] grid, int i)
    {
        var rowData = grid[i];
        var str = string.Join("",rowData);
        var original = Convert.ToInt32(str,2);

        var revRowData = rowData.Select(x => x == 0 ? 1 : 0).ToArray();
        var rev = string.Join("",revRowData);
        var revNum = Convert.ToInt32(rev,2);

        if(revNum > original)
            grid[i] = revRowData; 
    }

    public void InvertCol(int[][] grid, int j)
    {
        var rows = grid.Length;
        var numOf1 = 0;
        for(int i = 0 ; i < rows ;i++)
        {
            if(grid[i][j] == 1)
                numOf1++;
        }

        if(numOf1 <= rows/2)
            for(int i = 0 ; i < rows ;i++)
            {
                grid[i][j] = grid[i][j] == 1 ? 0 : 1;
            }
    }
}