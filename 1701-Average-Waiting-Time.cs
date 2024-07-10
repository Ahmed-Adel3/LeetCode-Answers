public class Solution {
    public int MaxNumEdgesToRemove(int n, int[][] edges) {
        DSU dsu1 = new DSU(n);
        DSU dsu2 = new DSU(n);
        int count = 0;
        Array.Sort(edges, (a, b) => b[0] - a[0]);

        foreach(var edge in edges){
            if(edge[0] == 3){
                if(dsu1.find(edge[1]) == dsu1.find(edge[2]) && dsu2.find(edge[1]) == dsu2.find(edge[2])){
                    count++;
                    continue;
                }
                
                dsu1.union(edge[1], edge[2]);
                dsu2.union(edge[1], edge[2]);
            }
            else if(edge[0] == 1){
                if(dsu1.find(edge[1]) == dsu1.find(edge[2])){
                    count++;
                }

                dsu1.union(edge[1], edge[2]);
            }
            else{
                if(dsu2.find(edge[1]) == dsu2.find(edge[2])){
                    count++;
                }

                dsu2.union(edge[1], edge[2]);
            }
        }

        for(int i=1; i<=n; i++){
            dsu1.find(i);
            dsu2.find(i);
        }

        for(int i=2; i<=n; i++){
            if(dsu1.parent[i] != dsu1.parent[1] || dsu2.parent[i] != dsu2.parent[1]){
                return -1;
            }
        }

        return count;
    }

    class DSU {
        public int[] parent;

        public DSU(int n) {
            parent = new int[n+1];

            for (int i = 0; i <= n; i++) parent[i] = i;
        }

        public int find(int x) {
            if (parent[x] != x) parent[x] = find(parent[x]);
            return parent[x];
        }

        public void union(int x, int y) {
            parent[find(x)] = parent[find(y)];
        }
    }
}