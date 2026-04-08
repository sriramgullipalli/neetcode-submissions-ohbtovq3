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
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode curr = head;
        while (curr != null) {
            ListNode temp = curr.next; // 1. Save the next node before modifying curr.next
            curr.next = prev;          // 2. Reverse the current node's pointer
            prev = curr;               // 3. Move 'prev' pointer to current node
            curr = temp;               // 4. Move 'curr' pointer to the next node
        }
        return prev; 
    }
}
