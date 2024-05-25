public class Solution {
    public IList<string> WordBreak(string s, IList<string> wordDict) {
        HashSet<string> wordSet = new HashSet<string>(wordDict);
        Dictionary<int, List<string>> cache = new Dictionary<int, List<string>>();

        List<string> Backtrack(int i)
        {
            if (i == s.Length)
                return new List<string> { "" };
            if (cache.ContainsKey(i))
                return cache[i];
            List<string> res = new List<string>();
            for (int j = i; j < s.Length; j++)
            {
                string w = s.Substring(i, j - i + 1);
                if (!wordSet.Contains(w))
                    continue;
                List<string> strings = Backtrack(j + 1);
                if (strings.Count == 0)
                    continue;
                foreach (string substr in strings)
                {
                    string sentence = w;
                    if (!string.IsNullOrEmpty(substr))
                        sentence += " " + substr;
                    res.Add(sentence);
                }
            }
            cache[i] = res;
            return res;
        }

        return Backtrack(0);
    }
}