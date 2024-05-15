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
    public IList<IList<int>> LevelOrder(Node root) {      
        var q = new Queue<Node>();
        q.Enqueue(root);

        var res = new List<IList<int>>();
        if(root is null)
            return res;
            
        res.Add(new List<int>{root.val});

        int lvlSize = 1;
        int nextLvlSize = 0;

        var level = new List<int>();
        while(q.Count > 0)
        {
            var item = q.Dequeue();
            lvlSize--;
            foreach(var node in item.children)
            {
                q.Enqueue(node);
                level.Add(node.val);
                nextLvlSize++;
            }
            
            if(level.Count > 0 && lvlSize == 0)
            {
                lvlSize = nextLvlSize;
                nextLvlSize = 0;
                res.Add(level);
                level = new List<int>();
            }
        }
        return res;
    }
}