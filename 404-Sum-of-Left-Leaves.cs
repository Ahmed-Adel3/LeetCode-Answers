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
    public int SumOfLeftLeaves(TreeNode root) {
        return CountLeftLeaves(root);
    }

    public int CountLeftLeaves(TreeNode node){
        if(node == null)
            return 0;

        var sum = 0;
        if(node.left != null && node.left.right == null && node.left.left == null)
            sum = node.left.val;
        return sum + CountLeftLeaves(node.left) + CountLeftLeaves(node.right);
    }
}