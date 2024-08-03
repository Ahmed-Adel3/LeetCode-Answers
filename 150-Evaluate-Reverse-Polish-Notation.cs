public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        foreach(var c in tokens)
        {
            if(IsOperation(c))
                stack.Push(Apply(c,stack.Pop(),stack.Pop()));
            else
                stack.Push(int.Parse(c));
        }
        return stack.Pop();
    }

    public bool IsOperation(string str) 
        => str == \+\ || str == \-\ || str == \/\ || str == \*\;

    public int Apply(string opr, int num1, int num2)
    {
        switch(opr)
        {
            case \+\:
                return num1+num2;
            case \-\:
                return num2-num1;
            case \/\:
                return num2/num1;
            case \*\:
                return num1*num2;
        }
        return 0;
    }
}