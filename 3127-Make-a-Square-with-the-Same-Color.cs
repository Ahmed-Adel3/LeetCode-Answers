public class Solution {
    public bool CanMakeSquare(char[][] grid) {
        var counter = 0;
        for(int i=0; i < 2;i++)
        {
            for(int j=0; j < 2; j++)
            {
                if(grid[i][j] == 'W') counter++;
                if(grid[i][j+1] == 'W') counter++;
                if(grid[i+1][j] == 'W') counter++;
                if(grid[i+1][j+1] == 'W') counter++;
                
                if(counter >= 3)
                    return true;
                
                 counter=0;
                
                if(grid[i][j] == 'B') counter++;
                if(grid[i][j+1] == 'B') counter++;
                if(grid[i+1][j] == 'B') counter++;
                if(grid[i+1][j+1] == 'B') counter++;
                
                if(counter >= 3)
                    return true;
                
                counter=0;
            }
            
        }
        return false;
    }
}