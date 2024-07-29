public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var left = 0;
        var right = numbers.Length-1;
        while(left < right)
        {
            var sum = numbers[right] + numbers[left];
            if(sum == target)
                return new int[2] {left+1,right+1};
            else if(sum > target)
                right--;
            else
                left++;
        }
        return null;
    }
}