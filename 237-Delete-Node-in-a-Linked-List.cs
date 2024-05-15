/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        bool isLast = false;
        while(node.next != null)
        {
            if(node.next.next == null)
                isLast = true;
            node.val = node.next.val;
            if(!isLast)
                node = node.next;
            else
                node.next = null;
        }
    }
}