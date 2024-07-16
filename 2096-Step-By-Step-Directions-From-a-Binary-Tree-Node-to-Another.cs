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
private string Dfs(TreeNode node, List<char> path, int target) {
        if (node == null) return string.Empty;
        if (node.val == target) return new string(path.ToArray());

        path.Add('L');
        var res = Dfs(node.left, path, target);
        if (!string.IsNullOrEmpty(res)) return res;
        path.RemoveAt(path.Count - 1);

        path.Add('R');
        res = Dfs(node.right, path, target);
        if (!string.IsNullOrEmpty(res)) return res;
        path.RemoveAt(path.Count - 1);

        return string.Empty;
    }

    public string GetDirections(TreeNode root, int startValue, int destValue) {
        var startPath = Dfs(root, new List<char>(), startValue);
        var destPath = Dfs(root, new List<char>(), destValue);

        int i = 0;
        while (i < Math.Min(startPath.Length, destPath.Length) && startPath[i] == destPath[i]) {
            i++;
        }

        var res = new string('U', startPath.Length - i) + destPath.Substring(i);
        return res;
    }
}