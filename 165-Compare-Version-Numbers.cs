public class Solution {
    public int CompareVersion(string version1, string version2) {
        if(version1 == version2)
            return 0;
        
        var v1 = version1.Split('.').Select(int.Parse).ToList();
        var v2 = version2.Split('.').Select(int.Parse).ToList();
        var len = Math.Min(v1.Count,v2.Count);

        for(int i = 0; i < len; i++)
        {
            if(v1[i] > v2[i])
                return 1;
            else if(v1[i] < v2[i])
                return -1;
        }

        var isTaller1 = v1.Count >= v2.Count;
        var taller = isTaller1 ? v1 : v2;

        var rest = taller.Skip(len).ToList();
        if(rest.Any(a=>a > 0))
           return isTaller1? 1 : -1;
        else
            return 0;
    }
}