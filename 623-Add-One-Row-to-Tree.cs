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
    public TreeNode AddOneRow(TreeNode root, int val, int depth) {
        if(depth == 1)
            return new TreeNode(val,root);

        InsertValues(root,null,val,depth,0,"l");
        return root;
    }

    public void InsertValues(TreeNode node,TreeNode parentNode, int val, int depth, int currDepth,string dir)
    {
        currDepth++;
        if(depth == currDepth){
            var newNode = new TreeNode(val);
            if(dir == "l"){
                newNode.left = parentNode.left;
                parentNode.left = newNode;
            }
            else{
                newNode.right = parentNode.right;
                parentNode.right = newNode;
            };
            return;
        }
        if(node == null)
            return;
        InsertValues(node.left,node,val,depth,currDepth,"l");
        InsertValues(node.right,node,val,depth,currDepth,"r");
    }
}