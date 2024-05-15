public class Solution {
    public int MaxArea(int[] height) {
        int left = 0 , right = height.Length-1, maxArea = 0;
         
         while(left < right)
         {
            maxArea = Math.Max(maxArea, CalculateArea(left,right,height));
            if(height[left] > height[right])
                right--;
            else
                left ++;
         }
         return maxArea;     
    }

    public int CalculateArea(int left, int right, int[] height)
    {
        var h = Math.Min(height[left],height[right]);
        return h * (right-left);
    }
}