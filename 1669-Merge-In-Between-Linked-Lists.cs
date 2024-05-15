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
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2) {
        
        var lastNewNode = list2;
        while(lastNewNode.next != null)
        {
            lastNewNode = lastNewNode.next;
        }

        var counter = 0;
        var curNode = list1;
        ListNode restOfNode = null;
        while(counter <= b)
        {
            counter++;
            if(counter == b)
            {
                restOfNode = curNode.next.next;
                curNode.next = lastNewNode;
                lastNewNode.next = restOfNode;
                break;
            }
            curNode = curNode.next;     
        }


        counter = 0;
        curNode = list1;
        while(counter <= a)
        {
            counter++;
            if(counter == a)
            {
                curNode.next = list2;
                break;
            }
            curNode = curNode.next;
            
        }

        return list1;
    }
}