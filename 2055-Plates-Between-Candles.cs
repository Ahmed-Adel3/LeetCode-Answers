public class Solution {
    public int[] PlatesBetweenCandles(string s, int[][] queries) {
        var n = s.Length;
        var left_candles = new int[n];
        var right_candles = new int[n];
        var prefix = new int[n];

        prefix[0]       = s[0] == '*' ?  1 : 0 ;
        left_candles[0] = s[0] == '*' ? -1 : 0 ;

        for(int i = 1 ; i < n; i++)
        {
            prefix[i] = (s[i] == '*' ? 1 : 0 ) + prefix[i-1]; 
            left_candles[i] = s[i] == '*'? left_candles[i-1] : i;
        }
        
        right_candles[n-1] = s[n-1] == '*' ? n : n-1;
        for(int i = n-2; i >= 0 ; i--)
        {
            right_candles[i] = s[i] == '*' ? right_candles[i+1]:i; 
        }

        var res = new int[queries.Length];
        for(int i = 0 ; i < queries.Length;i++)
        {
            var start = right_candles[queries[i][0]];
            var end = left_candles[queries[i][1]];

            res[i] = start >= end ? 0 : prefix[end]-prefix[start];   
        }

        return res;
    }
}