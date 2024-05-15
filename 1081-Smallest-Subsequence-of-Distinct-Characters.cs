public class Solution {
    public string SmallestSubsequence(string s) {
        var arr = s.ToCharArray();

        var latestIndexDict = new Dictionary<char,int>();
        for(int i=arr.Length-1 ; i >=0 ; i--)
            if(!latestIndexDict.ContainsKey(arr[i]))
                latestIndexDict.Add(arr[i],i);

        var newArr = new List<char>();
        var check = new List<char>();

        for(int i = 0 ; i < arr.Length;i++ ){
            var cur = arr[i];
            if(!check.Contains(cur)){
                while(newArr.Any() && cur < newArr.Last() && i < latestIndexDict[newArr.Last()]){
                    newArr.RemoveAt(newArr.Count-1);
                    check.RemoveAt(check.Count-1);
                }

                newArr.Add(cur);
                check.Add(cur);
            }
        }

        return new string(newArr.ToArray());
    }
}