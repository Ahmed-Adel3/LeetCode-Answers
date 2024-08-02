public class Solution {
    public string MinWindow(string s, string t) {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || t.Length > s.Length)
            return \\;

        var dictT = new Dictionary<char, int>();
        
        foreach (var chr in t) {
            if (dictT.ContainsKey(chr)) 
                dictT[chr]++;
            else 
                dictT.Add(chr, 1);
        }

        var dictS = new Dictionary<char, int>();
        int left = 0, right = 0, minLength = int.MaxValue, start = 0;
        int required = dictT.Count, formed = 0;
        var windowCounts = new Dictionary<char, int>();

        while (right < s.Length) {
            char c = s[right];
            if (windowCounts.ContainsKey(c))
                windowCounts[c]++;
            else
                windowCounts[c] = 1;

            if (dictT.ContainsKey(c) && windowCounts[c] == dictT[c])
                formed++;

            while (left <= right && formed == required) {
                c = s[left];

                if (right - left + 1 < minLength) {
                    minLength = right - left + 1;
                    start = left;
                }

                windowCounts[c]--;
                if (dictT.ContainsKey(c) && windowCounts[c] < dictT[c])
                    formed--;

                left++;
            }

            right++;
        }

        return minLength == int.MaxValue ? \\ : s.Substring(start, minLength);
    }
}