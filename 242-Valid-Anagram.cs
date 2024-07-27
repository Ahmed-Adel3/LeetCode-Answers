public class Solution {
    public bool IsAnagram(string s, string t) {
            if(s.Length != t.Length) return false;

            var dictS = new Dictionary<char,int>();
            var dictT = new Dictionary<char,int>();

            FillDict(s,dictS);
            FillDict(t,dictT);

            foreach(var chr in s)
            {
                if(!dictT.ContainsKey(chr) || dictS[chr] != dictT[chr])
                    return false;
            }
            return true;
    }

    public void FillDict(string s,Dictionary<char,int> dict)
    {
            foreach(var chr in s)
            {
                if(dict.ContainsKey(chr))
                    dict[chr]++;
                else
                    dict.Add(chr,1);
            }
    }
}