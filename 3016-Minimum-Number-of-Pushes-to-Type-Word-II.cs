public class Solution {
    public int MinimumPushes(string word) {
        var dict = new int[26];

        foreach(var l in word)
            dict[l-'a']++;
        
        Array.Sort(dict);
        Array.Reverse(dict);
        
        var sum = 0;
        for(int i = 0 ; i < dict.Length ; i++)
        {
            sum += (dict[i] * ((i/8)+1));
        }
        return sum;
    }
}