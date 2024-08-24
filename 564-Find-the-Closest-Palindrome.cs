public class Solution
{
    // Convert to palindrome keeping first half constant.
    private long Convert(long num)
    {
        string s = num.ToString();
        int n = s.Length;
        int l = (n - 1) / 2, r = n / 2;
        char[] sArray = s.ToCharArray();
        while (l >= 0)
        {
            sArray[r++] = sArray[l--];
        }
        return long.Parse(new string(sArray));
    }

    // Find the next palindrome, just greater than n.
    private long NextPalindrome(long num)
    {
        long left = 0, right = num;
        long ans = long.MinValue;
        while (left <= right)
        {
            long mid = (right - left) / 2 + left;
            long palin = Convert(mid);
            if (palin < num)
            {
                ans = palin;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return ans;
    }

    // Find the previous palindrome, just smaller than n.
    private long PreviousPalindrome(long num)
    {
        long left = num, right = (long)1e18;
        long ans = long.MinValue;
        while (left <= right)
        {
            long mid = (right - left) / 2 + left;
            long palin = Convert(mid);
            if (palin > num)
            {
                ans = palin;
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        return ans;
    }

    public string NearestPalindromic(string n)
    {
        long num = long.Parse(n);
        long a = NextPalindrome(num);
        long b = PreviousPalindrome(num);
        if (Math.Abs(a - num) <= Math.Abs(b - num))
        {
            return a.ToString();
        }
        return b.ToString();
    }
}
