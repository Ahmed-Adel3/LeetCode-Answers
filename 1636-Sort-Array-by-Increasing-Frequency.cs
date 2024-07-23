public class Solution {
    public int[] FrequencySort(int[] nums) {
        Dictionary<int,int> occ = new();
        foreach(int num in nums)
        {
            if(occ.ContainsKey(num)) occ[num]++;
            else occ.Add(num,1);
        }
        Array.Sort(nums,new OccuranceComparer(occ));
        return nums;
    }

    public class OccuranceComparer : IComparer<int>
    {
        private readonly Dictionary<int, int> _occ;

        public OccuranceComparer(Dictionary<int, int> occ) {
            _occ = occ;
        }
        public int Compare (int x, int y)
        {
            var val1 = _occ[x];
            var val2 = _occ[y];
            var res=val1.CompareTo(val2);
            if(res == 0) return y.CompareTo(x);
            else return res;
        } 
    }
}