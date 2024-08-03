public class Solution {
    public bool CanBeEqual(int[] target, int[] arr) {
        Array.Sort(arr);
        Array.Sort(target);
        return Enumerable.SequenceEqual(target,arr);
    }
}