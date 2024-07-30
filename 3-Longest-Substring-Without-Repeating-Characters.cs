public class Solution {
        public int LengthOfLongestSubstring(string s) {
        var visited = new HashSet<char>();
        var max = 0;
        var startIndex = 0;
        
        for(int i = 0 ; i < s.Length ; i++)
        {
            if(visited.Contains(s[i]))
            {
                while(visited.Any() && visited.Contains(s[i]))
                {
                    visited.Remove(s[startIndex]);
                    startIndex++;
                }
            }
            visited.Add(s[i]);
            max = Math.Max(max,visited.Count);
        }
        return max;
    }
}