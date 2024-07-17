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
    public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete) {
       HashSet<int> toDeleteSet = new HashSet<int>(to_delete);
        HashSet<TreeNode> resSet = new HashSet<TreeNode> { root };

        TreeNode DFS(TreeNode node) {
            if (node == null) return null;

            TreeNode res = node;
            if (toDeleteSet.Contains(node.val)) {
                res = null;
                resSet.Remove(node);
                if (node.left != null) resSet.Add(node.left);
                if (node.right != null) resSet.Add(node.right);
            }

            node.left = DFS(node.left);
            node.right = DFS(node.right);
            return res;
        }

        DFS(root);
        return new List<TreeNode>(resSet);
    }
}