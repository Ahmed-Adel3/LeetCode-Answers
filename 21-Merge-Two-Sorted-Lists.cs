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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode cur1 = list1, cur2 = list2;

        var res = new ListNode(0,null);
        var last = res;

        while(cur1 != null || cur2 != null)
        {
            if(cur2 == null || cur1?.val <= cur2?.val)
            {
                last.next = cur1;
                cur1 = cur1.next;
            }
            else if(cur1 == null || cur1?.val > cur2?.val)
            {
                last.next = cur2;
                cur2 = cur2.next;
            }
            last = last.next;            
        }
        return res.next;
    }
}