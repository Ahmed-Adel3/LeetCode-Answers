public class Solution {
    public int NumIslands(char[][] grid) {
        var islands = 0;
        for(int i = 0 ; i < grid.Length ; i++){
            for(int j = 0 ; j < grid[i].Length ; j++){
                var item = grid[i][j];
                if(item == '0')
                    continue;             
                islands++;
                CheckDirections(i,j,grid);
            }
        }
        return islands;
    }

    public void CheckDirections(int i, int j , char[][] grid ){
        //check right
        if(j+1<grid[i].Length && grid[i][j+1] == '1'){
            grid[i][j+1] = '0';
            CheckDirections(i,j+1,grid);
        }
        //check left
        if(j-1 >= 0 && grid[i][j-1] == '1'){
            grid[i][j-1] = '0';
            CheckDirections(i,j-1,grid);
        }
        //check down
        if(i+1<grid.Length && grid[i+1][j] == '1'){
            grid[i+1][j] = '0';
            CheckDirections(i+1,j,grid);
        }
        //check up
        if(i-1 >= 0 && grid[i-1][j] == '1'){
            grid[i-1][j] = '0';
            CheckDirections(i-1,j,grid);
        }
    }


}