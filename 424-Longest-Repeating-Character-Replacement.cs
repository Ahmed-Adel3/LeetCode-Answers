public class Solution {
    public int CharacterReplacement(string s, int k) {
        var left = 0;
        var max = 0;
        var arr = new int[26];
        for(int i = 0 ; i < s.Length ; i++)
        {
            arr[s[i]-'A']++;
            while(i-left+1-arr.Max() > k)
            {
                arr[s[left]-'A']--;
                left++;
            }
            max = Math.Max(max,i-left+1);
        }
        return max;
    }
}