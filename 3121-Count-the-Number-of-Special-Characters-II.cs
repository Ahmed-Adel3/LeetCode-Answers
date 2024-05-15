public class Solution {
    public int NumberOfSpecialChars(string word) {
         int count = 0;
        var chr = new List<Char>();
        chr.AddRange(word);
        var visited = new List<int>();
        var list = chr.Select(a=>(int)a).ToList();
        for(int i = 0 ; i < list.Count ; i++){
            if(visited.Contains(list[i]))
                continue;
            var suspect = false;
            for(int j = i+1 ; j < list.Count; j++){
                if(list[i] - list[j] == 32 ){
                    suspect = true;
                }
                else if(suspect && list[i] == list[j]){
                    suspect = false;
                    break;
                }

            }
            if(suspect)
                count++;
            
            visited.Add(list[i]);
            if(list[i] >= 97)
               visited.Add(list[i]-32);
            else
               visited.Add(list[i]+32);
              
        }
        return count;
    }
}