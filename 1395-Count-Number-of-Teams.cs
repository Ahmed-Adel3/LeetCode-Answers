public class Solution {
    public int NumTeams(int[] rating) {
        var sum = 0;
        var numsOnLeft = 0;
        var numsOnRight = 0;

        for(int i = 1 ; i < rating.Length-1; i++)
        {
            for(int j = 0 ; j < rating.Length; j++)
            {
                if(i==j) continue;
                else if ( i > j && rating[i] > rating[j] ) //items on left
                    numsOnLeft++;
                else if ( i < j && rating[i] < rating[j]) //items on right
                    numsOnRight++;
            }
            sum+= numsOnLeft * numsOnRight;
            sum+= (i-numsOnLeft) * (rating.Length-numsOnRight-i-1);
            numsOnLeft = 0;
            numsOnRight = 0;
        }

        return sum;
    }
}