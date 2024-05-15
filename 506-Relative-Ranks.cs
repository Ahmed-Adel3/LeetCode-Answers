public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        var rank = new Dictionary<int,int>();

        for(int i = 0 ; i < score.Length ; i++)
        {        
            rank.Add(score[i] , i);
        }

        Array.Sort(score);
        Array.Reverse(score);

        var res = new string[score.Length];

        if(score.Length > 0)
            res[rank[score[0]]] = "Gold Medal";

        if(score.Length > 1)    
            res[rank[score[1]]] = "Silver Medal";

        if(score.Length > 2)       
            res[rank[score[2]]] = "Bronze Medal";

        for(int i = 3 ; i < score.Length ; i++)
        {        
            res[rank[score[i]]] =  (i+1).ToString(); 
        }
        return res;
    }
}