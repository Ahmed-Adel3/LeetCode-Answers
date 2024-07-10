public class Solution {
    public int MinOperations(string[] logs) {
        int res = 0;
        foreach(var log in logs)
        {
            if (log=="../" && res > 0)
                res--;
            else if(log!="./" && log!="../")
                res++;
        }
        return res;
    }
}