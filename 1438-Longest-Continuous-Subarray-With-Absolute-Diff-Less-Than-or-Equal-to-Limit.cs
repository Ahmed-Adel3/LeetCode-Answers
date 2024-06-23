public class Solution {
    public int LongestSubarray(int[] nums, int limit) {
               var sortedList = new SortedList<int, int>();
        int maxLength = 0;
        int windowStart = 0;

        for (int windowEnd = 0; windowEnd < nums.Length; windowEnd++)
        {
            int value = nums[windowEnd];
            if (sortedList.ContainsKey(value))
                sortedList[value]++;
            else
                sortedList.Add(value, 1);

            while (sortedList.Keys[sortedList.Count - 1] - sortedList.Keys[0] > limit)
            {
                int startValue = nums[windowStart];
                sortedList[startValue]--;
                if (sortedList[startValue] == 0)
                    sortedList.Remove(startValue);
                windowStart++;
            }

            maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
        }

        return maxLength;
    }
}