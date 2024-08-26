/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Postorder(Node root) {
        var res = new List<int>();
        DFS(root);
        return res;

        void DFS(Node node)
        {
            if(node == null) return;
            foreach(var child in node.children)
            {
                DFS(child);
            }
            res.Add(node.val);
        }
    }
}