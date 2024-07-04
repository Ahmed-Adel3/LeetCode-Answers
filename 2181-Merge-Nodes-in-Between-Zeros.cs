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
    public ListNode MergeNodes(ListNode head) {
        ListNode res = new ListNode(0); 
        ListNode resCurrent = res;
        var sum = -1;
        var current = head;
        while(current != null)
        {
            if(current.val == 0)
            {
                //res.Add(sum);
                resCurrent.next = new ListNode(sum);
                resCurrent = resCurrent.next;
                sum = 0;
            }
            else{
                sum+=current.val;
            } 
            current = current.next;
        }       
        return res.next.next;
    }
}