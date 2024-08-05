public class Solution {
    public string KthDistinct(string[] arr, int k) {
        var dict = new Dictionary<string,int>();

        foreach(var str in arr)
        {
            if(dict.ContainsKey(str))
                dict[str]++;
            else
                dict.Add(str,1);
        }
        int counter = 0;
        foreach(var kv in dict)
        {
            if(kv.Value == 1)
            {
                counter++;
                if(counter == k)
                    return kv.Key;
            }   
        }
        return string.Empty;
    }
}