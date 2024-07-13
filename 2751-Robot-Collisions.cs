public class Solution {
    public IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions) {
        var pq = new PriorityQueue<int, int>();
        for (var i = positions.Length - 1; i >= 0; --i) pq.Enqueue(i, positions[i]);
        var stack = new Stack<int>();
        while (pq.Count > 0)
        {
            var i = pq.Dequeue();
            if (directions[i] == 'R') stack.Push(i);
            else
            {
                while (stack.Count > 0 && healths[i] > 0)
                {
                    var ii = stack.Pop();
                    var l = healths[i];
                    var r = healths[ii];
                    if (r > l) stack.Push(ii);
                    healths[ii] -= (r > l ? 1 : r);
                    healths[i] -= (l > r ? 1 : l);
                }
            }
        }
        return healths.Where(h => h > 0).ToList();
    }
}