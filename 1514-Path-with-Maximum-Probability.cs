public class Graph
{
    public Dictionary<int,Vertex> Vertices;

    public Graph ()
    {
        Vertices = new Dictionary<int,Vertex>();
    } 

    public void AddEdges(int[][] edges, double[] succProb)
    {
        for(int i = 0 ; i < edges.Length; i++)
        {
            var myVertex = GetVertex(edges[i][0]);
            var myVertex2 = GetVertex(edges[i][1]);

            if(myVertex == null)
            {
                myVertex = new Vertex(edges[i][0]);
                Vertices.Add(edges[i][0],myVertex);
            }

            if(myVertex2 == null)
            {
                myVertex2 = new Vertex(edges[i][1]);
                Vertices.Add(edges[i][1],myVertex2);
            }
            myVertex2.children[myVertex] = succProb[i];
            myVertex.children[myVertex2] = succProb[i];
        }
    }

    public Vertex GetVertex(int val)
    {
        if (Vertices.TryGetValue(val, out Vertex vert))
        {
            return vert;
        }
        else
        {
            return null;
        }
    }
    
}

public class Vertex
{
    public bool visited = false;
    public int val;
    public double maxVal = -1;
    public int maxValSrc;
    public Dictionary<Vertex,double> children;
    public Vertex(int _val)
    {
        val = _val;
        children = new Dictionary<Vertex,double>();
    }
}

public class Solution {
    public double MaxProbability(int n, int[][] edges, double[] succProb, int start_node, int end_node) {
        var g = new Graph();
        g.AddEdges(edges,succProb);

        var startNode = g.GetVertex(start_node);
        var endNode = g.GetVertex(end_node);

        if(startNode == null || endNode == null)
            return 0;
        startNode.maxVal = 1;
        
        var q = new PriorityQueue<Vertex,double>();
        q.Enqueue(startNode,0);

        while(q.Count > 0)
        { 
            var vert = q.Dequeue();
            if(vert.val == end_node){
                return vert.maxVal;
            }

            vert.visited = true;

            foreach(var c in vert.children)
            {
                if(c.Key.visited || c.Value <= c.Key.maxVal )
                    continue;

                var mul = c.Value * vert.maxVal;
                var child = c.Key;

                if(mul > child.maxVal)
                {
                    child.maxVal =  mul;
                    child.maxValSrc = vert.val;
                    q.Enqueue(child,-mul);
                }
            }
        }

        return 0;
    }
}

