public class Solution {
    public long MaximumHappinessSum(int[] happiness, int k) {
        Array.Sort(happiness);
        Array.Reverse(happiness);
        long res = 0 ;

        for(long i = 0 ; i < k ; i++)
        {
            if(i >=  happiness.Length)
                break;

            var val = happiness[i] +  i*-1;
            if(val <= 0 )
                break;

            res += val;
        }
        return res;
    }
}