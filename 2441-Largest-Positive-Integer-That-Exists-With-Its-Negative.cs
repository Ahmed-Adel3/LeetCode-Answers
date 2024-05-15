public class Solution {
    public int FindMaxK(int[] nums) {
        var occurs = Enumerable.Repeat(0,1001).ToList(); 
        //0=> doesn't exist
        //1=> positive exits
        //2=> negative exits

        var max = -1;
        
        foreach(int i in nums){
            var index = Math.Abs(i);
            var occ = occurs[index];
            if(occ == 0)
            {
                if(i > 0)
                    occurs[index] = 1;
                else
                    occurs[index] = 2;
            } else
            {
                if( (i > 0 && occ == 2) ||
                    (i < 0 && occ == 1)   )
                    max = Math.Max(max,index);
            }
        }

        return max;        

    }
}