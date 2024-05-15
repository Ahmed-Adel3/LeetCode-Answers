public class Solution {
    public int LongestIdealString(string s, int k) {
        var lst = new int[26];
        var max = 1;
        for(int i = 0; i < s.Length; i++)
        {
            int chr = s[i]-'a';
            var start =  Math.Max(chr-k,0); 
            var end = Math.Min(chr+k,25);

            for (int j = start; j <= end; j++)
            {
                lst[chr] = Math.Max(lst[chr], lst[j]);
            }
            lst[chr]++;
            max= Math.Max(max,lst[chr]);
        }
        return max;
    }
}