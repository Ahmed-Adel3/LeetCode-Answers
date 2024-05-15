/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var res = new List<IList<int>>();
        if(root == null)
            return res;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count > 0)
        {
           var arr = new List<int>();
           var count = q.Count;
           for(int i = 0 ; i < count ; i++)
           {
                var item = q.Dequeue();
                arr.Add(item.val);
                
                if(item.left != null)
                    q.Enqueue(item.left);
                if(item.right != null)
                    q.Enqueue(item.right);
           }
           res.Add(arr);
        }
        return res;
    }
}