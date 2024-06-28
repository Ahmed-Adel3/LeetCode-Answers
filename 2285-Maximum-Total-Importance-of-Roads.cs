public class Solution {
    public long MaximumImportance(int n, int[][] roads) {
        var edgesArr = new long[n];

        foreach(var road in roads)
        {
            edgesArr[road[0]]++;
            edgesArr[road[1]]++;
        }   

        Array.Sort(edgesArr);
        var label = 1;
        long res = 0;
        for(int i = 0 ; i < edgesArr.Length ; i++)
        {
            res += edgesArr[i] * label;
            label++; 
        }
        return res;
    }
}