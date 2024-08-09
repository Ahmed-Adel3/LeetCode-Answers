public class Solution {
    public int CountSubstrings(string s) {
               var res = 0;

        for(int i = 0 ; i < s.Length;i++)
        {
            res += CountPalindromes(i,i);
            res += CountPalindromes(i,i+1);
        }

        return res;

        int CountPalindromes(int left, int right)
        {
            int count = 0;
            while(left >=0 && right <= s.Length-1 && s[left] == s[right])
            {
                count++;
                left--;
                right++;
            }
            return count;
        }
    }
}