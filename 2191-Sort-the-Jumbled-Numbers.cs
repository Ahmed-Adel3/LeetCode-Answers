public class Solution {
    public int[] SortJumbled(int[] mapping, int[] nums) {
        var dict = new List<(int,int)>();
        
        for(int i = 0 ; i < nums.Length ; i++)
        {
            dict.Add(new (nums[i],GetMapVal(nums[i])));
        }

        return dict.OrderBy(a=>a.Item2).Select(a=>a.Item1).ToArray();

        int GetMapVal(int num)
        {
            if(num == 0) return Array.IndexOf(mapping,0);
            int res = 0;
            int count = 1;
            while(num > 0)
            {
               res += mapping[num%10] * count;
               count *=10;
               num /=10;
            }
            return res;
        }
    }
}