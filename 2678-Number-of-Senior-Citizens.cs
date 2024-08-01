public class Solution {
    public int CountSeniors(string[] details) {
        return details.Count(a=> (a[11] == '6' && a[12] != '0') || a[11] == '7'||a[11] == '8'||a[11] == '9');
    }
}