public class Solution {
    public bool IsValid(string s) {
        var dict = new Dictionary<char,char>(){
            {'(',')'},
            {'{','}'},
            {'[',']'}
        };

        var stack = new Stack<char>();
        foreach(var c in s)
        {
            if(dict.ContainsKey(c))
                stack.Push(c);
            else if(!stack.Any() || dict[stack.Pop()] != c)
                return false;
        }
        return !stack.Any();
    }
}