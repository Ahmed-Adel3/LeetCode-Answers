public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var frequencyMap = new Dictionary<int, int>();
        foreach (var num in nums) {
            if (frequencyMap.ContainsKey(num)) {
                frequencyMap[num]++;
            } else {
                frequencyMap[num] = 1;
            }
        }

        // Step 2: Bucket sort the numbers based on their frequencies
        var buckets = new List<int>[nums.Length + 1];
        for (int i = 0; i < buckets.Length; i++) {
            buckets[i] = new List<int>();
        }

        foreach (var kvp in frequencyMap) {
            buckets[kvp.Value].Add(kvp.Key);
        }

        var result = new List<int>();
        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--) {
            if (buckets[i].Count > 0) {
                result.AddRange(buckets[i]);
            }
        }

        return result.ToArray();
    }
}