public class Solution {
    public bool JudgeSquareSum(int c) {
        double left = 0;
        double right = (int)Math.Sqrt(c);

        while(left <= right)
        {
            var num = left* left + right*right;
            if(num == c)
                return true;
            else if(num > c)
                right--;
            else
                left++;
        }
        return false;
    }
}