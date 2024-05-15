public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0)
            return false;

        var digits = (int) Math.Floor(Math.Log10(x));
        var num = x;
        var reverse = 0;
        do {
            reverse += (int)Math.Pow(10,digits--) * (num%10);
            num = num/10;
        } while(num>0) ;

        return reverse == x;
    }
}