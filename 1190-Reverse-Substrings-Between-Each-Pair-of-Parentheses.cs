public class Solution {
    public string ReverseParentheses(string s) {
                Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == ')')
            {
                List<char> portion = new List<char>();
                while (stack.Peek() != '(')
                {
                    portion.Add(stack.Pop());
                }
                stack.Pop(); // Remove the '('
                
                foreach (char p in portion)
                {
                    stack.Push(p);
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        return new string(stack.Reverse().ToArray());
    }
}