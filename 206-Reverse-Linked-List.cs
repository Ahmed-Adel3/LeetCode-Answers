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
    public ListNode ReverseList(ListNode head) {
        if(head == null) return null;
        return ReverseRecursively(head);
    }

    public ListNode ReverseRecursively(ListNode node, ListNode prev = null)
    {       
        if(node == null)
            return prev;
        var temp = node.next;
        node.next = prev;
        return ReverseRecursively(temp,node);
    }
}