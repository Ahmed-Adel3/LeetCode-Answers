public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        for(int i = 0 ; i < arr.Length - 2; i++)
        {
            if(arr[i]%2 == 1 && arr[i+1]%2 == 1 && arr[i+2]%2 == 1)
                return true;
        }
        return false;
    }
}