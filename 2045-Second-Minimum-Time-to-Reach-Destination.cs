public class Solution {
    public int SecondMinimum(int n, int[][] edges, int time, int change) {
        var adj = BuildGraph(edges);
        return BFS(n, adj, time, change);
    }

    private Dictionary<int, List<int>> BuildGraph(int[][] edges) {
        var adj = new Dictionary<int, List<int>>();
        foreach (var edge in edges) {
            if (!adj.ContainsKey(edge[0])) adj[edge[0]] = new List<int>();
            if (!adj.ContainsKey(edge[1])) adj[edge[1]] = new List<int>();
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }
        return adj;
    }

    // Function to manage the signal light change and update the current time
    private int UpdateCurrentTime(int curTime, int change, int time) {
        if ((curTime / change) % 2 == 1) {
            curTime += change - (curTime % change);
        }
        curTime += time;
        return curTime;
    }

    // Function to execute BFS to find the second minimum time
    private int BFS(int n, Dictionary<int, List<int>> adj, int time, int change) {
        var q = new Queue<int>();
        q.Enqueue(1);
        var curTime = 0;
        var res = -1;
        var visitTimes = new Dictionary<int, List<int>>();
        foreach (var key in adj.Keys) {
            visitTimes[key] = new List<int>();
        }

        while (q.Count > 0) {
            for (int i = 0, len = q.Count; i < len; i++) {
                var node = q.Dequeue();
                if (node == n) {
                    if (res != -1) return curTime;
                    res = curTime;
                }
                foreach (var nei in adj[node]) {
                    var neiTimes = visitTimes[nei];
                    if (neiTimes.Count == 0 || (neiTimes.Count == 1 && neiTimes[0] != curTime)) {
                        q.Enqueue(nei);
                        neiTimes.Add(curTime);
                    }
                }
            }
            curTime = UpdateCurrentTime(curTime, change, time);
        }

        return -1;
    }
}