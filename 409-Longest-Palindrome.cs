public class Solution {
    public int LongestPalindrome(string s) {
        var dict = new Dictionary<char,int>();

        for(int i = 0 ; i < s.Length; i++)
        {
            if(dict.ContainsKey(s[i]))
                dict[s[i]]++;
            else
                dict[s[i]] = 1;
        }

        var res = 0;
        var isSinleItemSelected = false;
        foreach(var kv in dict)
        {
            if(kv.Value%2 == 1)
            {         
                res += kv.Value -1;
                if(!isSinleItemSelected)
                {
                    res++;
                    isSinleItemSelected = true;
                }
            }
            else if(kv.Value%2 == 0)
            {
                res+= kv.Value;
            }
        }
        return res;
    }
}