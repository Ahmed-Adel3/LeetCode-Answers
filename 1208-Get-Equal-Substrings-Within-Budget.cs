public class Solution {
    public int EqualSubstring(string s, string t, int maxCost) {
        var current = 0;
        var left = 0;
        var res = 0;

        for(int i = 0 ; i < s.Length ; i++)
        {
            current += Math.Abs((int)s[i] - (int)t[i]);
            while(current > maxCost){
                current -= Math.Abs((int)s[left] - (int)t[left]);
                left++;
            }
            res = Math.Max(res, i -left +1 );
        }

        return res;
    }
}