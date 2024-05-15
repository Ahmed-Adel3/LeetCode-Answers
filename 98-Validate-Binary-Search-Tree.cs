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
    public bool IsValidBST(TreeNode root) {
        return CheckIsValidBST(root, double.MaxValue, double.MinValue);
    }

    public bool CheckIsValidBST(TreeNode root, double high,double low) {
        if(root == null)
            return true;
        
        var val = (double) root.val;

        if(val >= high || val <= low)
            return false;

        bool isLeftValid = CheckIsValidBST(root.left,val,low);
        bool isRightValid = CheckIsValidBST(root.right,high,val);

        return isRightValid && isLeftValid;
    }
}