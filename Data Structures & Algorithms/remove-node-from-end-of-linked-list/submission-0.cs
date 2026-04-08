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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
         ListNode dummy = new ListNode(0, head);
        ListNode fast = dummy;
        ListNode slow = dummy;

        // 2. Move the 'fast' pointer n steps ahead to create a gap of n nodes 
        // between 'fast' and 'slow'.
        for (int i = 0; i < n; i++) {
            fast = fast.next;
        }

        // 3. Move both 'fast' and 'slow' pointers one step at a time until 'fast' 
        // reaches the last node (i.e., fast.next is null).
        while (fast.next != null) {
            slow = slow.next;
            fast = fast.next;
        }

        // 4. At this point, 'slow' will be pointing to the node just before the 
        // one to be removed. Adjust its 'next' pointer to skip the target node.
        slow.next = slow.next.next;

        // 5. Return the 'next' of the dummy node, which is the head of the 
        // modified list.
        return dummy.next;
    }
}
