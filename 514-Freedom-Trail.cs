public class Solution {
public int FindRotateSteps(string ring, string key) {
        Dictionary<string, int> memo = new Dictionary<string, int>();
        return DFS(ring, key, 0, memo);
    }

    private int DFS(string ring, string key, int index, Dictionary<string, int> memo) {
        if (index == key.Length) return 0;
        string keyRing = ring + index.ToString(); // Create a unique key for memoization
        if (memo.ContainsKey(keyRing)) return memo[keyRing];
        
        char target = key[index];
        int minSteps = int.MaxValue;
        
        // Find all occurrences of the target character in the ring
        for (int i = 0; i < ring.Length; i++) {
            if (ring[i] == target) {
                int stepsToRotate = Math.Min(i, ring.Length - i); // Calculate steps to rotate
                string rotatedRing = RotateRing(ring, i); // Rotate the ring
                int steps = stepsToRotate + 1 + DFS(rotatedRing, key, index + 1, memo); // Calculate total steps
                minSteps = Math.Min(minSteps, steps);
            }
        }
        
        memo[keyRing] = minSteps; // Memoize the result
        return minSteps;
    }
    
    private string RotateRing(string ring, int steps) {
        return ring.Substring(steps) + ring.Substring(0, steps);
    }
}