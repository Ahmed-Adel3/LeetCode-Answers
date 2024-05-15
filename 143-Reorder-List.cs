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
    public void ReorderList(ListNode head) {
        var pointers = new List<ListNode>();

        var curr = head;
        while(curr != null)
        {
            pointers.Add(curr);
            curr = curr.next;
        }

        var len = pointers.Count%2==0 ? pointers.Count/2 : pointers.Count/2 +1;
        for(int i = 0 ; i < len ; i++)
        {
            var last = pointers[pointers.Count-1-i];
            if(i == len - 1)
                last.next = null;
            else
            {
                last.next = pointers[i+1];
                pointers[i].next = last;
            }
        }
    }
}