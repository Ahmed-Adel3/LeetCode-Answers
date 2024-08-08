public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var res = new List<IList<int>>();
        var arr = new HashSet<int>();
        BackTrack();
        void BackTrack()
        {
            if(arr.Count == nums.Length)
            { 
                res.Add(arr.ToList());  
                return;
            }

            foreach(var num in nums)
            {
                if(arr.Contains(num))
                    continue;
                arr.Add(num);
                BackTrack();
                arr.Remove(num);
            }
        }
        return res;
    }
}