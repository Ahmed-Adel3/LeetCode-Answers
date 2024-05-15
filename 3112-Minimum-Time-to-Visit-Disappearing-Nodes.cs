public class Node {
    public int Id { get; }
    public int Time { get; }
    public Node(int id, int time) {
        Id = id;
        Time = time;
    }
}

public class Solution {
    public int[] MinimumTime(int n, int[][] edges, int[] disappear) {
        var graph = new Dictionary<int, List<(int, int)>>();

        foreach (var edge in edges) {
            int u = edge[0];
            int v = edge[1];
            int w = edge[2];

            if (!graph.ContainsKey(u)) {
                graph[u] = new List<(int, int)>();
            }
            graph[u].Add((v, w));

            if (!graph.ContainsKey(v)) {
                graph[v] = new List<(int, int)>();
            }
            graph[v].Add((u, w));
        }

        var answer = new int[n];
        Array.Fill(answer, -1);
        answer[0] = 0;

        var minHeap = new SortedSet<Node>(Comparer<Node>.Create((a, b) => {
            if (a.Time != b.Time) return a.Time.CompareTo(b.Time);
            return a.Id.CompareTo(b.Id);
        }));
        minHeap.Add(new Node(0, 0));

        while (minHeap.Count > 0) {
            var node = minHeap.Min;
            minHeap.Remove(node);

            if (answer[node.Id] != node.Time) continue;

            foreach (var (nextNode, nextTime) in graph.GetValueOrDefault(node.Id, new List<(int, int)>())) {
                int totalTime = node.Time + nextTime;
                if (totalTime < disappear[nextNode] && (answer[nextNode] == -1 || totalTime < answer[nextNode])) {
                    answer[nextNode] = totalTime;
                    minHeap.Add(new Node(nextNode, totalTime));
                }
            }
        }

        return answer;
    }
}