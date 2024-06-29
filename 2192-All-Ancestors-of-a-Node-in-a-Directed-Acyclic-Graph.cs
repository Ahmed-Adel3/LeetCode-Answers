public class Solution {
    public IList<IList<int>> GetAncestors(int n, int[][] edges) {
        List<IList<int>> res = new List<IList<int>>();
        for (int i = 0; i < n; i++) {
            res.Add(new List<int>());
        }

        List<int>[] graph = new List<int>[n];
        for (int i = 0; i < n; i++) {
            graph[i] = new List<int>();
        }
        foreach (var edge in edges) {
            graph[edge[0]].Add(edge[1]);
        }

        for (int i = 0; i < n; i++) {
            DFS(graph, i, i, res, new bool[n]);
        }

        for (int i = 0; i < n; i++) {
            ((List<int>)res[i]).Sort();
        }

        return res;
    }

    private void DFS(List<int>[] graph, int parent, int curr, List<IList<int>> res, bool[] visit) {
        visit[curr] = true;
        foreach (var dest in graph[curr]) {
            if (!visit[dest]) {
                res[dest].Add(parent);
                DFS(graph, parent, dest, res, visit);
            }
        }
    }
}