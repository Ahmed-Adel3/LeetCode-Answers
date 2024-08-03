public class Solution {
    public int EvalRPN(string[] tokens) {
         var stack = new Stack<int>();
        int sum = 0; 
        foreach(var c in tokens)
        {
            sum = int.MinValue;
            if(IsOperation(c))
            {
                if(stack.Any())
                {
                    sum = Apply(c,stack.Pop(),stack.Pop());
                    stack.Push(sum);
                }
            }
            else{
                sum = int.Parse(c);
                stack.Push(sum);
            }
        }
        return sum;
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
                if(num1 == 0) return 0;
                return num2/num1;
            case \*\:
                return num1*num2;
        }
        return 0;
    }
}