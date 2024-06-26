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
    public TreeNode BalanceBST(TreeNode root) {
        
        var arr = new List<int>();
        InOrderTraversal(root);
        return BuildTree(arr,0,arr.Count-1);

        void InOrderTraversal(TreeNode node)
        {
            if(node == null) return;

            //add left first
            InOrderTraversal(node.left);
            //then add the middle
            arr.Add(node.val);
            //then add right ==> so that the list is sorted
            InOrderTraversal(node.right);
        }

        TreeNode BuildTree(List<int> arr, int start, int end)
        {
            if(end < start) return null;

            int mid = (start+end)/2;
            var newRoot = new TreeNode(arr[mid]);

            newRoot.left = BuildTree(arr,start,mid-1);
            newRoot.right = BuildTree(arr,mid+1,end);

            return newRoot;
        }
    }
}