public class Solution {
    public bool IsValid(string s) {
        if(s.Length%2 == 1 || string.IsNullOrWhiteSpace(s))
            return false;
            
        var adj = new Dictionary<char,char>() 
        {
            {'[',']'},
            {'{','}'},
            {'(',')'}
        };
        
        var stk = new Stack<char>();
        
        for(int i=0; i < s.Length; i++)
        {
            if(stk.Count == 0){
                if(!adj.ContainsKey(s[i]))
                    return false;
                stk.Push(s[i]);
                continue;
            }
                
            var item = stk.Peek();    
            if(adj[item] != s[i]){
                if(!adj.ContainsKey(s[i]))
                    return false;
                stk.Push(s[i]);
            }
            else
                stk.Pop();         
        }
        
        return stk.Count == 0;
    }
}