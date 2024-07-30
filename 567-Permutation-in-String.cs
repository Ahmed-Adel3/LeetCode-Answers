public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length) return false;
        
        var s1Dict = new int[26];
        var s2Dict = new int[26];

        for(int i = 0 ; i < s1.Length ; i++)
        {
            s1Dict[s1[i]-'a']++;
            s2Dict[s2[i]-'a']++;
        }

        if(Enumerable.SequenceEqual(s1Dict,s2Dict)) return true;

        for(int i = s1.Length ; i < s2.Length ; i++)
        {
            s2Dict[s2[i]-'a']++;
            s2Dict[s2[i-s1.Length]-'a']--;

            if(Enumerable.SequenceEqual(s1Dict,s2Dict)) return true;
        }
        return false;
    }
}