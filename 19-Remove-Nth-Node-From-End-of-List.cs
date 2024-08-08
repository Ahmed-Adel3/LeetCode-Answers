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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var reversed = Reverse(head);
        var counter = 1;
        ListNode curr = reversed;
        ListNode prev = null;

        while(curr != null && counter < n)
        {
            counter++;
            prev = curr;
            curr = curr.next;
        }
        if (prev == null)
            reversed = curr.next;
        else
            prev.next = curr.next;
        return Reverse(reversed);
    }

    public ListNode Reverse(ListNode head)
    {
        ListNode curr = head;
        ListNode prev = null;

        while(curr != null)
        {
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        } 
        return prev;
    }

}