public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
      var ans = new Dictionary<string,IList<string>>();

      foreach(var str in strs)
      {
        var charLst = new int[26];
        foreach(var chr in str)
            charLst[chr-'a']++;

        var key = string.Join(\,\,charLst);
        if(ans.ContainsKey(key))
            ans[key].Add(str);
        else 
            ans.Add(key,new List<string>{str});
      }   
      return ans.Values.ToList(); 
    }
}