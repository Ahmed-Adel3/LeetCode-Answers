public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var res = new List<string>();
        var sol = new StringBuilder();
        backtrack(0,0);
        return res;

        void backtrack(int open,int close)
        {
            if (open == n && close == n)
            {
                res.Add(sol.ToString());
                return;
            }

            if (open < n)
            {
                sol.Append('(');
                backtrack(open + 1, close);
                sol.Length--; // Remove the last character
            }

            if (open > close)
            {
                sol.Append(')');
                backtrack(open, close + 1);
                sol.Length--; // Remove the last character
            }
        }
    }
}