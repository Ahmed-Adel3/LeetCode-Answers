public class Solution {
    public int BitwiseComplement(int n) {
        int bitLength =(int) Math.Log(n,2) + 1;
        int mask = ( 1 << bitLength ) -1;
        return n ^ mask;
    }
}