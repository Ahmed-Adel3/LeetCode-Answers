public class Solution {
    public int MaxDistance(int[] position, int m) {
        Array.Sort(position);
        int min = 0;
        int max = position[position.Length-1];
        int res = -1;
        while(max >= min)
        {
            int mid = (min+max)/2;
            if(IsSuitableDistance(mid))
            {
                res= mid;
                min = mid+1;
            }
            else
                max = mid-1;
        }
        return res;

        bool IsSuitableDistance(int point)
        {
            int counter = 1;
            int prevId = 0;
            for(int i = 1 ; i < position.Length; i++)
            {
                if(position[i] - position[prevId] >= point)
                {
                    counter++;
                    prevId = i;
                }
            }
            return counter >= m;
        }
    }
}