public class Solution {
    public int Trap(int[] height) {
        var res = 0;
        int left = 0, right = height.Length-1;
        int maxLeft = height[left], maxRight = height[right];
        while(left < right)
        {
            if(maxLeft < maxRight){
                left++;
                maxLeft = Math.Max(maxLeft,height[left]); 
                res += maxLeft - height[left]; 
            }
            else
            {
                right--;
                maxRight = Math.Max(maxRight,height[right]);
                res+= maxRight - height[right];
            }
        }
        return res;
    }
}