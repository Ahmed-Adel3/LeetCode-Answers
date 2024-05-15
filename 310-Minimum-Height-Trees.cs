public class Solution {
 public IList<int> FindMinHeightTrees(int n, int[][] edges) {
        // If there is only one node, return it as the root of the minimum height tree
        if (n == 1) {
            return new List<int>{0};
        }

        // Create an adjacency list to represent the graph
        var adjList = new List<int>[n];
        for (int i = 0; i < n; i++) {
            adjList[i] = new List<int>();
        }

        // Populate the adjacency list based on the edges
        foreach (var edge in edges) {
            int u = edge[0];
            int v = edge[1];
            adjList[u].Add(v);
            adjList[v].Add(u);
        }

        // Find all leaf nodes (nodes with only one neighbor) as the starting point
        var leaves = new List<int>();
        for (int i = 0; i < n; i++) {
            if (adjList[i].Count == 1) {
                leaves.Add(i);
            }
        }

        // Keep track of the remaining nodes to process
        int remainingNodes = n;

        // Continue until there are only 1 or 2 nodes left
        while (remainingNodes > 2) {
            // Reduce the remaining nodes by the number of current leaf nodes
            remainingNodes -= leaves.Count;
            
            // Create a new list to store the new leaf nodes for the next iteration
            var newLeaves = new List<int>();
            
            // Remove current leaf nodes and update their neighbors
            foreach (var leaf in leaves) {
                int neighbor = adjList[leaf][0];
                adjList[neighbor].Remove(leaf);
                
                // If the neighbor becomes a leaf node, add it to the new leaves list
                if (adjList[neighbor].Count == 1) {
                    newLeaves.Add(neighbor);
                }
            }
            
            // Update the current leaf nodes for the next iteration
            leaves = newLeaves;
        }

        // At this point, the remaining nodes are the centers of the minimum height trees
        return leaves;
}
}