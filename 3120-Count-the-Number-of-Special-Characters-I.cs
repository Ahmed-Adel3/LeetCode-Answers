public class Solution {
    public int NumberOfSpecialChars(string word) {
        int count = 0;
        var chr = new List<Char>();
        chr.AddRange(word);
        var list = chr.Select(a=>(int)a).Distinct().ToList();
        for(int i = 0 ; i < list.Count ; i++){
            for(int j = i+1 ; j < list.Count; j++){
                if(Math.Abs(list[j] - list[i]) == 32 ){
                    count++;
                    continue;
                }
            }
        }
        return count;
    }
}