public class Solution {
    public bool CheckString(string s) {
        var bFound = false;
        foreach(var c in s)
        {
            if(bFound && c == 'a') return false;
            if(c == 'b') bFound = true;
        }
        return true;
    }
}