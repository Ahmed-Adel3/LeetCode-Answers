public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var cols = new Dictionary<int,HashSet<char>>();
        var rows = new Dictionary<int,HashSet<char>>();
        var squares = new Dictionary<string,HashSet<char>>();

        for(int r = 0 ; r < 9 ; r++) //row
        {
            for(int c = 0 ; c < 9 ; c++)//col
            {
                var chr = board[r][c];
                if(chr =='.') continue;
                if(cols.TryGetValue(r,out var colSet) && colSet.Contains(chr) ||
                   rows.TryGetValue(c,out var rowSet) && rowSet.Contains(chr) ||
                   squares.TryGetValue($\{r/3},{c/3}\,out var squareSet) && squareSet.Contains(chr)) 
                   return false;
                
                cols.TryAdd(r,new HashSet<char>());
                rows.TryAdd(c,new HashSet<char>());
                squares.TryAdd($\{r/3},{c/3}\,new HashSet<char>());

                cols[r].Add(chr);
                rows[c].Add(chr);
                squares[$\{r/3},{c/3}\].Add(chr);
            }
        }
        return true;
    }
}