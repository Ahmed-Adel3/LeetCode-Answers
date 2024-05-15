public class Solution {
    public string RemoveDuplicateLetters(string s) {
        var charArr = s.ToCharArray();

        //get a dict with last index of each letter
        var lastIndexDict = new Dictionary<char,int>();

        for(int i = charArr.Length-1 ; i >= 0 ; i--)
        {
            if(!lastIndexDict.ContainsKey(charArr[i]))
                lastIndexDict.Add(charArr[i],i);
        }

        var newCharArr = new List<char>();
        var seenArr = new List<char>();

        for(int i = 0 ; i < charArr.Length ; i++)
        {
            var cur = charArr[i];
            if(!seenArr.Contains(cur))
            {
                while(newCharArr.Any() && cur < newCharArr.Last()  &&  i<lastIndexDict[newCharArr.Last()])
                {
                    newCharArr.RemoveAt(newCharArr.Count-1);
                    seenArr.RemoveAt(seenArr.Count-1);
                }
                newCharArr.Add(cur);
                seenArr.Add(cur);
            }
        }

        return new string(newCharArr.ToArray());
    }
}