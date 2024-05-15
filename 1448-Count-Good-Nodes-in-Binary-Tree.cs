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
    public int GoodNodes(TreeNode root) {
        int count = 0;
        IsChildGood(root,ref count,root.val);
        return count;
    }

    public void IsChildGood(TreeNode node,ref int count,int maxValue){
        if(node is not null){
            if(node.val >= maxValue){
                count++;
                maxValue = node.val;
            }

            IsChildGood(node.left,ref count,maxValue);   
            IsChildGood(node.right,ref count,maxValue);
        }
    }
}