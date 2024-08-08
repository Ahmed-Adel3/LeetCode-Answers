//Iterative Solution
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode cur = head, prev = null;

        while(cur is not null)
        {
            var temp = cur.next;
            cur.next = prev;
            prev = cur;
            cur = temp;
        } 
        return prev;
    }
}
//Recursive Solution
// public class Solution {
//     public ListNode ReverseList(ListNode head) {
//         if(head == null) return null;
//         return ReverseRecursively(head);
//     }

//     public ListNode ReverseRecursively(ListNode node, ListNode prev = null)
//     {       
//         if(node == null)
//             return prev;
//         var temp = node.next;
//         node.next = prev;
//         return ReverseRecursively(temp,node);
//     }
// }