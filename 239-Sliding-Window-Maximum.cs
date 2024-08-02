public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var res = new int[nums.Length-k+1];
        var left = 0; 
        var deque = new LinkedList<int>();

        for (int right = 0; right < nums.Length; right++) {
            // Remove indices that are out of the current window
            if (deque.Any() && deque.First.Value < right - k + 1) {
                deque.RemoveFirst();
            }

            // Remove elements from the back of the queue that are less than the current element
            while (deque.Any() && nums[deque.Last.Value] < nums[right]) {
                deque.RemoveLast();
            }

            // Add current element at the back of the queue
            deque.AddLast(right);

            // Set result for the current window
            if (right >= k - 1) {
                res[left++] = nums[deque.First.Value];
            }
        }
        return res;
    }
}