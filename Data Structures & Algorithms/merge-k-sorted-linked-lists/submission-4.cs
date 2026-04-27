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
    public ListNode MergeKLists(ListNode[] lists) {
        var minHeap = new PriorityQueue<ListNode, int>();
        foreach (ListNode node in lists) {
            if (node != null) {
                minHeap.Enqueue(node, node.val);
            }
        }
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        while (minHeap.Count > 0) {
            ListNode smallest = minHeap.Dequeue();
            current.next = smallest;
            current = current.next;
            if (smallest.next != null) {
                minHeap.Enqueue(smallest.next, smallest.next.val);
            }
        }
        return dummy.next;
    }
}
