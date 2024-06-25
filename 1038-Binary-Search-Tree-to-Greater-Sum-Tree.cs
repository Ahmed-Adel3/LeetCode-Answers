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
    public TreeNode BstToGst(TreeNode root) {
        var sum = 0;

        dfs(root);
        return root;

        void dfs(TreeNode node)
        {
            if(node == null)
                return;

            dfs(node.right);
            var temp = node.val;
            node.val += sum; 
            sum += temp;
            dfs(node.left);
        }
    }
}