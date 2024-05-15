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
    public bool IsPalindrome(ListNode head) {
        if(head == null) return false;

        var list = new List<int>();
        
        ListNode curr = head;
        while(curr!=null)
        {
            list.Add(curr.val);
            curr = curr.next;
        }

        for(int i = 0; i < list.Count/2; i++ )
        {
            if(list[i] != list[list.Count-1-i])
                return false;
        }
        return true;
    }
}