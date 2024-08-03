public class MinStack {
    List<int> dict;
    List<int> min;

    public MinStack() {
        dict = new List<int>();
        min = new List<int>();
    }
    
    public void Push(int val) {
        dict.Add(val);
        var valToAdd = !min.Any() || val <= min.Last() ? val : min.Last();
        min.Add(valToAdd); 
    }
    
    public void Pop() {
        dict.RemoveAt(dict.Count-1);
        min.RemoveAt(min.Count-1);
    }
    
    public int Top() {
        return dict.LastOrDefault();
    }
    
    public int GetMin() {
        return min.LastOrDefault();       
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */