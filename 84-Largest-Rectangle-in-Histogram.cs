public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var maxArea = 0;
        var stack = new Stack<(int index, int height)>();

        for(int i = 0 ; i < heights.Length ; i++)
        {
            var start = i;
            while(stack.Any() && stack.Peek().height > heights[i])
            {
                (int index, int height) = stack.Pop();
                maxArea = Math.Max(maxArea, height*(i-index));
                start = index;
            }
            stack.Push((start,heights[i]));
        }

        foreach((int i , int h) in stack)
            maxArea = Math.Max(maxArea, h *(heights.Length-i));

        return maxArea;
    }
}