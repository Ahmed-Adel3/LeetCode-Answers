public class Solution {
    public int OpenLock(string[] deadends, string target) {
         HashSet<string> deadSet = new HashSet<string>(deadends);
        HashSet<string> visited = new HashSet<string>();
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("0000");
        visited.Add("0000");
        int level = 0;

        while (queue.Count > 0) {
            int size = queue.Count;
            for (int i = 0; i < size; i++) {
                string current = queue.Dequeue();
                if (deadSet.Contains(current)) continue;
                if (current == target) return level;

                for (int j = 0; j < 4; j++) {
                    for (int k = -1; k <= 1; k += 2) {
                        char[] currentArray = current.ToCharArray();
                        int digit = (currentArray[j] - '0' + k + 10) % 10;
                        currentArray[j] = (char) (digit + '0');
                        string next = new string(currentArray);
                        if (!visited.Contains(next) && !deadSet.Contains(next)) {
                            queue.Enqueue(next);
                            visited.Add(next);
                        }
                    }
                }
            }
            level++;
        }
        return -1; // Target not reachable
    }
}