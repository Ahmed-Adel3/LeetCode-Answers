public class Solution {
    public bool IsValid(string word) {
       if (word.Length < 3)
            return false;

        bool hasVowel = false;
        bool hasConsonant = false;

        foreach (char c in word)
        {
            if (char.IsLetter(c))
            {
                if (IsVowel(c))
                    hasVowel = true;
                else
                    hasConsonant = true;
            }
            else if (!char.IsDigit(c))
            {
                return false;
            }
        }

        return hasVowel && hasConsonant;
    }
    
    static bool IsVowel(char c)
    {
        return "AEIOUaeiou".IndexOf(c) != -1;
    }
}