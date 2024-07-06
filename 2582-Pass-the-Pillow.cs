public class Solution {
    public int PassThePillow(int n, int time) {
        bool isForward = ( time/(n-1)) %2 == 0;
        int rest = time%(n-1);
        return isForward ? rest +1 : n-rest;
    }
}