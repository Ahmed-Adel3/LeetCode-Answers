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
    public ListNode RemoveNodes(ListNode head) {
        var rev = Reverse(head);
        var max = rev.val;
        var node = rev;

        while(node.next != null)
        {
            if(max > node.next.val)
            {
                node.next = node.next.next;
            }
            else
            {
                node = node.next;
                max = node.val;
            }
        }
        return Reverse(rev);
    }

    public ListNode Reverse(ListNode node,ListNode prev = null)
    {
        if(node == null)
            return prev;
        var temp = node.next;
        node.next = prev;
        return Reverse(temp,node); 
    }
}