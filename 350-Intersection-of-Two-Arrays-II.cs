public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var dict = new Dictionary<int,(int,int)>();
        foreach(int i in nums1)
        {
            if(dict.ContainsKey(i))
            {
                dict[i] = (dict[i].Item1+1,0);
            }
            else
                dict.Add(i,(1,0));
        }

        foreach(int i in nums2)
        {
            if(dict.ContainsKey(i))
            {
                dict[i] = (dict[i].Item1,dict[i].Item2+1);
            }
        }

        var res = new List<int>();
        foreach(var item in dict)
        {
            for(int i = 0 ; i < Math.Min(item.Value.Item1,item.Value.Item2) ; i++)
            {
                res.Add(item.Key);
            }
        }

        return res.ToArray();
    }
}