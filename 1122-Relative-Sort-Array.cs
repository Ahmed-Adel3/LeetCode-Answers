public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        var occ = new SortedDictionary<int,int>();

        //O(arr1 Len)
        for(int i = 0 ; i < arr1.Length ; i++)
        {
            if(!occ.ContainsKey(arr1[i]))
                occ.Add(arr1[i],1);
            else{
                occ[arr1[i]] +=1;
            }
        }

        var res = new int[arr1.Length];
        var index = 0;

        //O(arr2 Len * max item occ)
        for(int i = 0 ; i < arr2.Length ; i++)
        {
            var numOfOcc = occ[arr2[i]];
            for(int j = 0 ; j < numOfOcc ; j++)
            {
                res[index] = arr2[i];
                index ++;
            }
            occ.Remove(arr2[i]);
        }

        foreach(var keyVal in occ)
        {
            var numOfOcc = keyVal.Value;
            for(int j = 0 ; j < numOfOcc ; j++)
            {
                res[index] = keyVal.Key;
                index ++;
            }
        }
        return res;
    }
}