public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        if(edges.Length == 0) 
            return n == 1;

        var graph = new Dictionary<int,SortedSet<int>>();
        var visited = new HashSet<int>();
        for(int i = 0; i < edges.Length ; i++)
        {
            if(!graph.ContainsKey(edges[i][0]))
                graph.Add(edges[i][0], new SortedSet<int>());

            if(!graph.ContainsKey(edges[i][1]))
                graph.Add(edges[i][1], new SortedSet<int>());

                graph[edges[i][0]].Add(edges[i][1]);
                graph[edges[i][1]].Add(edges[i][0]);
        }

        return DFS(graph,visited,source,destination);
    }

    public bool DFS(Dictionary<int,SortedSet<int>> graph, HashSet<int> visited, int n, int dest)
    {
        if(n == dest)
            return true;

        visited.Add(n);
        foreach(int i in graph[n])
        {
            if(!visited.Contains(i) && DFS(graph,visited,i,dest))
                   return true;
        }
        return false;
    }
}