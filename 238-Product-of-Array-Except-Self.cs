public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
         var totalMul = 1;
        var hasZero = false;
        var zeroIndex = -1;
        for(int i = 0 ; i < nums.Length ;i++)
        {
            if(nums[i] == 0)
            {
                if(hasZero) 
                    return new int[nums.Length]; 
                hasZero = true;
                zeroIndex = i;
            }
            else
                totalMul*= nums[i];
        }
        Console.WriteLine(zeroIndex);
        if(hasZero)
        {
            var res = new int[nums.Length];
            res[zeroIndex] = totalMul;
            return res;
        }
        
        for(int i = 0 ; i < nums.Length ;i++)
        {
            nums[i] = totalMul/nums[i];
        }
        return nums;
    }
}