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
    public ListNode DoubleIt(ListNode head) {
        var rev = Reverse(head);
        var node = rev;
        var carry = 0;

        while(node != null)
        {
             var doubleVal = node.val * 2 + carry;
            if(doubleVal >= 10)
            {
                carry = 1;
                node.val = doubleVal - 10;
            }
            else
            {
                carry = 0;
                node.val = doubleVal;
            }
            if(node.next == null)
                break;

            node = node.next;
        }

        if(carry == 1)
        {
            node.next = new ListNode(1);
        }

        return Reverse(rev);
    }

    public ListNode Reverse(ListNode node, ListNode prev = null)
    {
        if(node == null)
        return prev;

        var temp = node.next;
        node.next = prev;

        return Reverse(temp,node);
    }
}