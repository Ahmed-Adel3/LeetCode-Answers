public class Solution {
    public int AppendCharacters(string s, string t) {

        var sp = 0; var tp = 0;

        while(sp < s.Length && tp < t.Length)
        {
            if(s[sp] == t[tp])
            {
                sp++;
                tp++;
            }
            else
            {
                sp++;
            }
        }

        return t.Length - tp;
    }
}