public class Solution {
    public int FindTheCity(int n, int[][] edges, int distanceThreshold) {
        // Initialize adjacency list
        var adjacencyList = BuildAdjacencyList(n, edges);

        // Function to perform Dijkstra's algorithm from a given source node
        int Dijkstra(int source) {
            var priorityQueue = new SortedSet<(int distance, int node)>();
            var visited = new HashSet<int>();
            priorityQueue.Add((0, source));

            while (priorityQueue.Any()) {
                var (currentDistance, currentNode) = priorityQueue.Min;
                priorityQueue.Remove(priorityQueue.Min);

                if (visited.Contains(currentNode)) continue;

                visited.Add(currentNode);

                foreach (var (neighbor, weight) in adjacencyList[currentNode]) {
                    var newDistance = currentDistance + weight;
                    if (newDistance <= distanceThreshold) {
                        priorityQueue.Add((newDistance, neighbor));
                    }
                }
            }

            return visited.Count - 1; // Exclude the source node
        }

        int resultCity = -1, minReachableCities = n;
        for (int city = 0; city < n; city++) {
            int reachableCities = Dijkstra(city);
            if (reachableCities <= minReachableCities) {
                resultCity = city;
                minReachableCities = reachableCities;
            }
        }

        return resultCity;
    }

    // Helper function to build the adjacency list from the edges
    private Dictionary<int, List<(int, int)>> BuildAdjacencyList(int n, int[][] edges) {
        var adjacencyList = new Dictionary<int, List<(int, int)>>();

        for (int i = 0; i < n; i++) {
            adjacencyList[i] = new List<(int, int)>();
        }

        foreach (var edge in edges) {
            int from = edge[0], to = edge[1], weight = edge[2];
            adjacencyList[from].Add((to, weight));
            adjacencyList[to].Add((from, weight));
        }

        return adjacencyList;
    }
}