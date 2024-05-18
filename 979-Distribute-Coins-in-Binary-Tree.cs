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
    private int moves = 0;

    public int DistributeCoins(TreeNode root) {
        Dfs(root);
        return moves;
    }

    private int Dfs(TreeNode node) {
        if (node == null) 
            return 0;
        int leftExcess = Dfs(node.left);
        int rightExcess = Dfs(node.right);
        moves += Math.Abs(leftExcess) + Math.Abs(rightExcess);
        return node.val + leftExcess + rightExcess - 1;
    }
}