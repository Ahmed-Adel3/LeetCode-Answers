public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        var dict = new List<(string,int)>();

        for(int i = 0 ; i < names.Length;i++)
            dict.Add((names[i],heights[i]));

        return dict.OrderByDescending(a=>a.Item2).ToList().Select(a=>a.Item1).ToArray();
    }
}