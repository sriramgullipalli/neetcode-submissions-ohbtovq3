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
         // Initialize a min-heap (PriorityQueue)
        var minHeap = new PriorityQueue<ListNode, int>();

        // Push the head of each non-empty list into the heap
        foreach (ListNode node in lists) {
            if (node != null) {
                minHeap.Enqueue(node, node.val);
            }
        }

        // Create a dummy node to build the result list
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        // Process the heap until it is empty
        while (minHeap.Count > 0) {
            // Extract the node with the smallest value from the heap
            ListNode smallest = minHeap.Dequeue();
            
            // Append the smallest node to the merged list
            current.next = smallest;
            current = current.next;

            // If the extracted node has a next node, push it into the heap
            if (smallest.next != null) {
                minHeap.Enqueue(smallest.next, smallest.next.val);
            }
        }

        // The merged list starts from the next of the dummy node
        return dummy.next;
    }
}
