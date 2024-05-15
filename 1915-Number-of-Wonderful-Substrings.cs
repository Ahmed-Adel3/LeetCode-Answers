public class Solution {
    public long WonderfulSubstrings(string word) {
        var freq = new long[1024];
        freq[0] = 1;
        
        long result = 0;
        var mask = 0; 
        foreach(var ch in word){
            mask ^= (1<<ch-'a');
            result += freq[mask];   

            for(var curr='a'; curr<='j'; curr++){
                var maskToCheck = mask ^ (1<<curr-'a');
                result += freq[maskToCheck];   
            }
            freq[mask]++;
        }
        return result;
    }
}