public class Solution {
    public int FindTheWinner(int n, int k) {
        var list = Enumerable.Range(1,n).ToList();
        int index = 0;
        while(list.Count > 1)
        {
            index += k -1;
            while(index >= list.Count)
            {
                index = index - list.Count;
            }
            list.RemoveAt(index);
        }
        return list[0];
    }
}