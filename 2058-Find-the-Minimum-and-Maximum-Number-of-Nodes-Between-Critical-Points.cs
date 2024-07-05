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
    public int[] NodesBetweenCriticalPoints(ListNode head) {
        if(head == null || head.next == null || head.next.next == null)
            return new int[] {-1,-1};

        var prev = head;
        var cur = head.next;
        var nxt = cur.next;

        long minDist = long.MaxValue;
        int maxDist = -1;
        int prevCritIdx = 0;
        int firstCritIdx = 0;
        int i = 1; // index of cur

        while (nxt != null)
        {
            if (Critical(prev, cur, nxt))
            {
                if (firstCritIdx > 0)
                {
                    maxDist = i - firstCritIdx;
                    minDist = Math.Min(minDist, i - prevCritIdx);
                }
                else
                {
                    firstCritIdx = i;
                }
                prevCritIdx = i;
            }

            prev = cur;
            cur = nxt;
            nxt = nxt.next;
            i += 1;
        }

        if (minDist == float.PositiveInfinity)
        {
            minDist = -1;
        }

        return new int[] {(int)minDist, maxDist};

        bool Critical(ListNode prev, ListNode cur, ListNode nxt)
        {
            return (prev.val > cur.val && cur.val < nxt.val) ||
                (prev.val < cur.val && cur.val > nxt.val);
        }
    }
}