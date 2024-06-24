public class Solution {
    public int MinKBitFlips(int[] nums, int k) {
        var res = 0;
        var queue = new Queue<int>();

        for(int i = 0 ; i < nums.Length ; i++)
        {
            while(queue.Any() && i > queue.Peek()+k-1)
            {
                //to check the last valid index this flip will effect 
                //ex. [0,1,1,1] => for the first element, the last item 
                //   the flip will effect is at index k + i
                queue.Dequeue();
            }
            if((nums[i]+queue.Count)%2 == 0) //if true => perform a flip
            {
                if( i+k > nums.Length) //check if we have enough elements to flip 
                    return -1;
                res++;
                queue.Enqueue(i); //saying that we made a flip in this part
            }
        }
        return res;
    }
}