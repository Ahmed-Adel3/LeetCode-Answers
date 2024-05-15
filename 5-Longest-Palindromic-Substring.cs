public class Solution {
    public string LongestPalindrome(string s) {

        var str = "";
        for(int i = 0 ; i < s.Length ; i++){
            var sub = s[i].ToString();
            getPallindromic(ref str,s,sub,i-1,i+1);

            if( s.Length > i+1 && s[i] == s[i+1]){
                sub = s[i].ToString()+s[i+1].ToString();
                getPallindromic(ref str,s,sub,i-1,i+2);
            }
        }
        
        return str;
    }

    public void getPallindromic(ref string pal,string original,string sub,int left, int right){
        if(pal.Length < sub.Length)
             pal = sub;
        while(left >= 0 && right < original.Length && original[left] == original[right]){
            sub = original[left]+sub+original[right];
            if(pal.Length < sub.Length)
                 pal = sub;
            left -- ; right ++;
        }
    }
}