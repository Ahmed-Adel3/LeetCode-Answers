public class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        IList<IList<int>> res = new List<IList<int>>();
        Array.Sort(candidates);

        void Dfs(int i, List<int> cur, int total)
        {
            if (total == target)
            {
                res.Add(new List<int>(cur));
                return;
            }
            if (total > target || i == candidates.Length)
            {
                return;
            }

            // include candidates[i]
            cur.Add(candidates[i]);
            Dfs(i + 1, cur, total + candidates[i]);
            cur.RemoveAt(cur.Count - 1);

            // skip candidates[i]
            while (i + 1 < candidates.Length && candidates[i] == candidates[i + 1])
            {
                i++;
            }
            Dfs(i + 1, cur, total);
        }

        Dfs(0, new List<int>(), 0);
        return res;
    }
}
