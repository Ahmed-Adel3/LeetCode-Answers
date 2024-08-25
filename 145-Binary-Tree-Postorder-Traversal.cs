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
    public IList<int> PostorderTraversal(TreeNode root) {
        var res = new List<int>();
        DFS(root);
        return res;
        void DFS(TreeNode node)
        {
            if(node == null) return;
            if(node.left != null) DFS(node.left);
            if(node.right != null) DFS(node.right);
            res.Add(node.val);
        }
    }
}