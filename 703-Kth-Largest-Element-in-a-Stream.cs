public class KthLargest {
    private List<int> numsList;
    private int k;
    public KthLargest(int k, int[] nums) {
        this.k = k;
        numsList = new List<int>(nums);
        numsList.Sort();
    }
    
    public int Add(int val) {
        // Insert the value into the sorted list
        int index = numsList.BinarySearch(val);
        if (index < 0) index = ~index;
        numsList.Insert(index, val);
        
        // Return the kth largest element
        return numsList[numsList.Count - k];
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */