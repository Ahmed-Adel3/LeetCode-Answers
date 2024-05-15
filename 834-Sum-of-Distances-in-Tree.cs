public class Solution {
    public int[] SumOfDistancesInTree(int n, int[][] edges) {
        List<int>[] graph = new List<int>[n];
        for (int i = 0; i < n; i++) {
            graph[i] = new List<int>();
        }
        foreach (var edge in edges) {
            int u = edge[0], v = edge[1];
            graph[u].Add(v);
            graph[v].Add(u);
        }

        int[] count = new int[n];
        int[] ans = new int[n];
        
        // Step 1: Calculate subtree sizes and initial answers
        DFS(0, -1, graph, count, ans);
        
        // Step 2: Calculate answers for each node
        DFS2(0, -1, graph, count, ans);
        
        return ans;
    }

    private void DFS(int node, int parent, List<int>[] graph, int[] count, int[] ans) {
        count[node] = 1;
        foreach (int child in graph[node]) {
            if (child != parent) {
                DFS(child, node, graph, count, ans);
                count[node] += count[child];
                ans[node] += ans[child] + count[child];
            }
        }
    }
    
    // DFS to update answers for each node
    private void DFS2(int node, int parent, List<int>[] graph, int[] count, int[] ans) {
        foreach (int child in graph[node]) {
            if (child != parent) {
                ans[child] = ans[node] - count[child] + count.Length - count[child];
                DFS2(child, node, graph, count, ans);
            }
        }
    }
}