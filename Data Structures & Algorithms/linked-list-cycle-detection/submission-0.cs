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
    public bool HasCycle(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next; // Move one step
            fast = fast.next.next; // Move two steps

            if (slow == fast)
            {
                return true; // Cycle detected: pointers met
            }
        }

        return false; // No cycle: fast pointer reached the end

    }
}
