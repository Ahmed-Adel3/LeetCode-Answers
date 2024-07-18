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
    private int pairs = 0;

    private Dictionary<int, int> Dfs(TreeNode node, int distance) {
        if (node == null) {
            return new Dictionary<int, int>();
        }

        if (node.left == null && node.right == null) {
            var count = new Dictionary<int, int>();
            count[1] = 1;
            return count;
        }

        var leftDist = Dfs(node.left, distance);
        var rightDist = Dfs(node.right, distance);

        foreach (var d1 in leftDist) {
            foreach (var d2 in rightDist) {
                if (d1.Key + d2.Key <= distance) {
                    pairs += d1.Value * d2.Value;
                }
            }
        }

        var allDist = new Dictionary<int, int>();
        foreach (var d in leftDist) {
            if (d.Key + 1 <= distance) {
                if (!allDist.ContainsKey(d.Key + 1)) {
                    allDist[d.Key + 1] = 0;
                }
                allDist[d.Key + 1] += d.Value;
            }
        }
        foreach (var d in rightDist) {
            if (d.Key + 1 <= distance) {
                if (!allDist.ContainsKey(d.Key + 1)) {
                    allDist[d.Key + 1] = 0;
                }
                allDist[d.Key + 1] += d.Value;
            }
        }

        return allDist;
    }

    public int CountPairs(TreeNode root, int distance) {
        pairs = 0;
        Dfs(root, distance);
        return pairs;
    }
}