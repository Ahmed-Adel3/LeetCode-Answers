public class Solution {
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker) {
        Array.Sort(difficulty, profit);
        Array.Sort(worker);
        
        int i = 0, j = 0, maxpro = 0, res = 0;
        
        while(j < worker.Length)
        {
            if(i < difficulty.Length && difficulty[i] <= worker[j])
            {
                maxpro = Math.Max(maxpro, profit[i]);
                i++;
            }
            else
            {
                res += maxpro;
                j++;
            }
        }
        return res;
    }
}