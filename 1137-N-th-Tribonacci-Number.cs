public class Solution {
    public int Tribonacci(int n) {      
        if(n == 0) return 0;
        else if( n == 1 || n == 2 ) return 1;
        else{
            var memory = new List<int>{0,1,1};
            var i = 3;
            while(i <= n){
                memory.Add(memory[i-1]+memory[i-2]+memory[i-3]);
                i++;
            }
            return memory[memory.Count-1];
        } 
    }
}