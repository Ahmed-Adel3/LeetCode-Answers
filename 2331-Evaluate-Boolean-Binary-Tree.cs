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
    public bool EvaluateTree(TreeNode root) {
        if(root == null)
            return false;
        if(root.right == null)
            return root.val == 1;
        else
            if(root.val == 2)
                return EvaluateTree(root.right) || EvaluateTree(root.left);
            else
                return EvaluateTree(root.right) && EvaluateTree(root.left);
    }
}