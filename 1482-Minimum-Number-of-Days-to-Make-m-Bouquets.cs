public class Solution {
    public int MinDays(int[] bloomDay, int m, int k) {
        if (bloomDay.Length < m * k) 
            return -1;

        var maxDays = bloomDay.Max();
        var minDays = bloomDay.Min();
        var mid = 0;

        bool canMakeBouquets = false;
        bool isEqualChecked = false;
        while(maxDays >= minDays && !isEqualChecked)
        {
            if(minDays == maxDays)
                isEqualChecked = true;
            mid = (int) (maxDays+minDays)/2;
            if(CanMakeBouquets(mid)){
                maxDays = mid;
                canMakeBouquets = true;
            }
            else
                minDays = mid + 1;
        }
        return canMakeBouquets ? minDays : -1;

        bool CanMakeBouquets(int days)
        {
            var res = 0;
            var counter = 0;
            foreach(var day in bloomDay)
            {
                if(days >= day)
                    counter++;
                else{
                    res += (int) counter/k;
                    counter = 0;
                }
            }
            res += (int) counter/k;
            return res >= m;
        }
    }
}