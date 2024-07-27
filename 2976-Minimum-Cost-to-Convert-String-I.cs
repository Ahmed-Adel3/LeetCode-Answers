public class Solution {
    public long MinimumCost(string source, string target, char[] original, char[] changed, int[] cost) {
        var adj = new Dictionary<char,List<(char adjChr,int adjDist)>>();

        for(int i = 0 ; i < original.Length;i++)
        {
            var chrOr = original[i];
            var chrCh = changed[i];
            var chrCost = cost[i];

            if(adj.ContainsKey(chrOr))
                adj[chrOr].Add((chrCh,chrCost));
            else
                adj.Add(chrOr,new List<(char adjChr,int adjDist)>{(chrCh,chrCost)});
        }

        Dictionary<Char,int> Dijkestra(char src)
        {
            var heap = new SortedSet<(int dist,char chr)>();
            var dict = new Dictionary<Char,int>();

            heap.Add((0,src));

            while(heap.Any())
            {
                (int curDist, char curChr) = heap.Min;
                heap.Remove(heap.Min);
                
                if(dict.ContainsKey(curChr)) continue;
                dict.Add(curChr,curDist);

                if(!adj.ContainsKey(curChr)) continue;

                var neighbours = adj[curChr];
                foreach(var nei in neighbours)
                {
                    var totalDist = curDist + nei.adjDist;
                    if(!dict.ContainsKey(nei.adjChr) || totalDist < dict[nei.adjChr])
                        heap.Add((totalDist,nei.adjChr));
                }
            }
            return dict;
        }

        var maps = new Dictionary<char,Dictionary<Char,int>>();
        for(int i = 0; i < source.Length ; i++)
        {
            if(!maps.ContainsKey(source[i]))
                maps.Add(source[i],Dijkestra(source[i]));
        }
        long res = 0;
        for(int i = 0 ; i < source.Length ; i++)
        {
            var src = source[i];
            var tar = target[i];

            if(!maps[src].ContainsKey(tar)) return -1;
            var shortestPath = maps[src][tar];
            res+=shortestPath;
        }
        return res;
    }
}