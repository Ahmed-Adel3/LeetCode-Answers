public class Solution {
    public bool IsPalindrome(string s) {
        var arr = s.ToLower()
            .ToCharArray()
            .Where(a=> { var num = Convert.ToInt32(a); 
            return (num >= 97 && num <=122) || (num >= 48 && num <=57);} ).ToList();
        if(arr.Count == 1) return true;

        for(int i = 0 ; i < arr.Count/2 ; i++)
        {
            if(arr[i] != arr[arr.Count-1-i])
                return false;
        }
        return true; 
    }
}