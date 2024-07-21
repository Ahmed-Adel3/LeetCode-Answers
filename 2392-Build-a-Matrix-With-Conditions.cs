using System;
using System.Collections.Generic;

public class Solution {
    public int[][] BuildMatrix(int k, int[][] rowConditions, int[][] colConditions) {
        int[] rowOrder = TopoSort(rowConditions, k);
        int[] colOrder = TopoSort(colConditions, k);
        
        if (rowOrder.Length == 0 || colOrder.Length == 0) {
            return new int[0][];
        }
        
        int[][] matrix = new int[k][];
        for (int i = 0; i < k; i++) {
            matrix[i] = new int[k];
        }
        
        // Fill the matrix based on the orders
        for (int i = 0; i < k; i++) {
            int rowPos = Array.IndexOf(rowOrder, i + 1);
            int colPos = Array.IndexOf(colOrder, i + 1);
            
            if (rowPos >= 0 && rowPos < k && colPos >= 0 && colPos < k) {
                matrix[rowPos][colPos] = i + 1;
            }
        }
        
        return matrix;
    }
    
    private int[] TopoSort(int[][] edges, int n) {
        List<int>[] adj = new List<int>[n + 1];
        for (int i = 0; i <= n; i++) {
            adj[i] = new List<int>();
        }
        
        int[] inDegree = new int[n + 1];
        foreach (var edge in edges) {
            int u = edge[0];
            int v = edge[1];
            adj[u].Add(v);
            inDegree[v]++;
        }
        
        Queue<int> queue = new Queue<int>();
        for (int i = 1; i <= n; i++) {
            if (inDegree[i] == 0) {
                queue.Enqueue(i);
            }
        }
        
        List<int> result = new List<int>();
        while (queue.Count > 0) {
            int node = queue.Dequeue();
            result.Add(node);
            foreach (int neighbor in adj[node]) {
                if (--inDegree[neighbor] == 0) {
                    queue.Enqueue(neighbor);
                }
            }
        }
        
        if (result.Count != n) {
            return new int[0]; // Cycle detected or not all nodes are reachable
        }
        
        return result.ToArray();
    }
}