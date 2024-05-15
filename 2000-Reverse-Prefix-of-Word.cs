public class Solution {
    public string ReversePrefix(string word, char ch) {
        var arr = word.ToCharArray();
        var index = Array.IndexOf(arr,ch)+1;
        return new String((arr.Take(index).Reverse()).Concat(arr.Skip(index)).ToArray());
    }
}