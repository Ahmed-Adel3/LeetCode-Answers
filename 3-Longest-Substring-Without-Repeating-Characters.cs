public class Solution {
    public int LengthOfLongestSubstring(string s) {

        if(s == "" ) 
            return 0;

        if( s.Length == 1)
            return 1;
        
        var Str = string.Empty;
        var longestLen = 0;

        for(int i = 0 ; i < s.Length ; i++ )
        {
            var charIndex = Str.IndexOf(s[i]);
            if(charIndex == -1){
              Str += s[i];
              if(i == s.Length -1)
                 longestLen = Str.Length > longestLen ? Str.Length : longestLen;
            }
            else{
              longestLen = Str.Length > longestLen ? Str.Length : longestLen;
              Str = Str.Substring(charIndex+1,Str.Length-charIndex-1)+s[i];
            }
        }

        return longestLen;
    }
}