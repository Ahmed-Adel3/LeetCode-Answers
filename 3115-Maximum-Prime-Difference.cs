public class Solution {
    public int MaximumPrimeDifference(int[] nums) {
        int? firstIndex = null;
        int? lastIndex = null;
        for(int i  = 0 ; i < nums.Length ; i++)
        {
            if(IsPrime(nums[i]))
            {
                if (firstIndex == null)
                   firstIndex = i;
                lastIndex = i;
            }              
        }
        
        if(firstIndex == null)
            return 0;
        
        return Math.Abs((int)lastIndex-(int)firstIndex);
    }
    
        private static bool IsPrime(int number)
        {
            if(number == 1)
                return false;
            
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
}