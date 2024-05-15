public class Trie {

    public Trie[] Children {get;set;}
    public bool IsEnd {get;set;} 
    
    public Trie(){
        Children = new Trie[26];
        IsEnd = false;
    }
    
    public void Insert(string word) {
        var curr = this;
        foreach(char c in word)
        {   
            var index = c-'a';
            if(curr.Children[index] == null)
               curr.Children[index] = new Trie();
            curr = curr.Children[index];
        }
        curr.IsEnd = true;
    }
    
    public bool Search(string word) {
        var curr = this;
        foreach(char c in word)
        {
            var index = c-'a';
            if(curr.Children[index] != null)
                curr = curr.Children[index];
            else return false; 
        }
        return curr.IsEnd;
    }
    
    public bool StartsWith(string prefix) {
        var curr = this;
        foreach(char c in prefix)
        {
            var index = c-'a';
            if(curr.Children[index] != null)
                curr = curr.Children[index];
            else return false;
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */