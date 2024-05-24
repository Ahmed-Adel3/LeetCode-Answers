public class Solution {
    public int MaxScoreWords(string[] words, char[] letters, int[] score) {
        Dictionary<char, int> letterCount = letters.GroupBy(c => c)
                                                   .ToDictionary(g => g.Key, g => g.Count());

        int Backtrack(int i) {
            if (i == words.Length) {
                return 0;
            }

            int res = Backtrack(i + 1);  // skip

            if (CanFormWord(words[i], letterCount)) {  // include (when possible)
                foreach (char c in words[i]) {
                    letterCount[c]--;
                }
                res = Math.Max(res, GetScore(words[i], score) + Backtrack(i + 1));
                foreach (char c in words[i]) {
                    letterCount[c]++;
                }
            }

            return res;
        }

        return Backtrack(0);
    }

    private bool CanFormWord(string word, Dictionary<char, int> letterCount) {
        Dictionary<char, int> wordCount = word.GroupBy(c => c)
                                              .ToDictionary(g => g.Key, g => g.Count());
        foreach (var kvp in wordCount) {
            if (!letterCount.ContainsKey(kvp.Key) || wordCount[kvp.Key] > letterCount[kvp.Key]) {
                return false;
            }
        }
        return true;
    }

    private int GetScore(string word, int[] score) {
        int result = 0;
        foreach (char c in word) {
            result += score[c - 'a'];
        }
        return result;
    }
}