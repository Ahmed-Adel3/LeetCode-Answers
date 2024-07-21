public class Solution {
    public int MinDays(int[] bloomDay, int m, int k) {
        if (bloomDay.Length < m * k) 
            return -1;

        var maxDays = bloomDay.Max();
        var minDays = 1;
        var res = -1;

        while(maxDays >= minDays)
        {
            var mid = (maxDays+minDays)/2;
            if(CanMakeBouquets(mid)){
                res = mid;
                maxDays = mid - 1;
            }
            else
                minDays = mid + 1;
        }
        return res;

        bool CanMakeBouquets(int days)
        {
            var res = 0;
            var counter = 0;
            for(int i = 0 ; i < bloomDay.Length ; i++)
            {
                if(days >= bloomDay[i])
                    counter++;
                else{
                    res += counter/k;
                    counter = 0;
                }
            }
            res += counter/k;
            return res >= m;
        }
    }
}