public class Solution {
    public int FindComplement(int num) {
        int bitLength = (int)Math.Log(num, 2) + 1;
        
        int mask = (1 << bitLength) - 1;
        
        return num ^ mask; 
    }
}