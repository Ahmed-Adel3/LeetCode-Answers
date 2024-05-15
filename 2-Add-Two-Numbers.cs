/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var nums = (GetListStr(l1)+GetListStr(l2)).ToString().Select(i => int.Parse(i.ToString())).ToList();
        var res = new ListNode(nums[0]);
        for(int i = 1; i< nums.Count; i++)
           res = new ListNode(nums[i],res); 
        return res;
    }

    public static BigInteger GetListStr(ListNode lst)
    {
        var sum = new StringBuilder(lst.val.ToString()); 
        while(lst.next != null)
        {
            lst = lst.next;   
            sum.Insert(0,lst.val);
        };
        return BigInteger.Parse(sum.ToString());
    }
}