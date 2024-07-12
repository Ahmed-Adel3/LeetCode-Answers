public class Solution {
    public int MaximumGain(string s, int x, int y) {

        var res = 0;
        var bigPair = x > y ? "ab" : "ba";
        var smallpair = bigPair == "ab" ? "ba" : "ab";
        res += GetScore(bigPair , Math.Max(x,y));
        res += GetScore(smallpair , Math.Min(x,y));
        return res;

        int GetScore(string pair, int score)
        {
            var stack = new Stack<char>();
            var res = 0;
            foreach(char chr in s)
            {
                if(stack.Count > 0 && stack.Peek() == pair[0] && chr == pair[1])
                {    
                    stack.Pop();
                    res += score;
                }
                else
                    stack.Push(chr);
            }
            s = new string(stack.ToArray().Reverse().ToArray());
            return res;
        }
    }
}