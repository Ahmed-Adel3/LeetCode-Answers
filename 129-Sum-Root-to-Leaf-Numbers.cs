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
    public int SumNumbers(TreeNode root) {
        return SumNum(root,0);
    }

    public int SumNum(TreeNode node, int sum)
    {
        if(node == null)
            return 0;
        sum = sum * 10 + node.val;
        if(node.left == null && node.right == null)
            return sum;
        return SumNum(node.left,sum) + SumNum(node.right,sum);
    }
}