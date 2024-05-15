public class Solution {
    public double MincostToHireWorkers(int[] quality, int[] wage, int k) {
        var dict = new List<(int,double)>();
        for(int i = 0; i < quality.Length; i++)
        {
            dict.Add((quality[i],(double)wage[i]/quality[i]));
        }
        dict = dict.OrderBy(a=>a.Item2).ToList(); //OrderByDescending

        var ratios = new PriorityQueue<int,int>();
        var totalQuality = 0d;
        var res = 0d;

        var maxPriority = 0;
        for(int i = 0; i < dict.Count; i++)
        {
            var item = dict[i];
            ratios.Enqueue(item.Item1,-1*item.Item1);
            totalQuality += item.Item1;

            if( i+1 >= k)
            {
                res = res == 0 ? (totalQuality*item.Item2) : Math.Min(res, totalQuality*item.Item2);
                totalQuality -= ratios.Dequeue();
            }
        }
        return res;
    }
}