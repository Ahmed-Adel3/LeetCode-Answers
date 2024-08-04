public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var res = new int[temperatures.Length];
        var stack = new Stack<(int temp, int index)>();

        for(int i = 0 ; i < temperatures.Length; i++)
        {
            while(stack.Any() && stack.Peek().temp < temperatures[i])
            {
                (int t, int idx) = stack.Pop();
                res[idx] = i-idx;
            }
            stack.Push((temperatures[i],i));
        }
        return res;
    }
}