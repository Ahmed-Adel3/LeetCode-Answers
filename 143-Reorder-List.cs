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
        ListNode slow = head, fast = head.next;
        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        //reversing second array
        var second = slow.next;
        var prev = slow.next = null; 

        while(second != null)
        {
            var temp = second.next;
            second.next = prev;
            prev = second;
            second = temp;
        }

        var first = head;
        second = prev;

        while(second is not null)
        {
            var temp1 = first.next;
            var temp2 = second.next;

            first.next = second;
            second.next = temp1;
            first = temp1;
            second = temp2;
        }
    }
}
//solution with extra space ----->
// public class Solution {
//     public void ReorderList(ListNode head) {
//         var pointers = new List<ListNode>();

//         var curr = head;
//         while(curr != null)
//         {
//             pointers.Add(curr);
//             curr = curr.next;
//         }

//         var len = pointers.Count%2==0 ? pointers.Count/2 : pointers.Count/2 +1;
//         for(int i = 0 ; i < len ; i++)
//         {
//             var last = pointers[pointers.Count-1-i];
//             if(i == len - 1)
//                 last.next = null;
//             else
//             {
//                 last.next = pointers[i+1];
//                 pointers[i].next = last;
//             }
//         }
//     }
// }