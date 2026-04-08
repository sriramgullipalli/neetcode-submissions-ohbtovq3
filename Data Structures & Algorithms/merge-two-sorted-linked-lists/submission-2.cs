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
         ListNode dummy = new ListNode(0);
        // 'curr' tracks the current tail of the merged list
        ListNode curr = dummy;

        // Iterate while both lists have nodes to compare
        while (list1 != null && list2 != null) {
            if (list1.val <= list2.val) {
                curr.next = list1;  // Attach the smaller node (from list1)
                list1 = list1.next; // Move list1 pointer forward
            } else {
                curr.next = list2;  // Attach the smaller node (from list2)
                list2 = list2.next; // Move list2 pointer forward
            }
            curr = curr.next; // Move the 'curr' pointer to the newly added node
        }

        // Attach any remaining nodes from whichever list is not empty
        // The remaining nodes are already sorted
        if (list1 != null) {
            curr.next = list1;
        } else if (list2 != null) {
            curr.next = list2;
        }
        
        // The merged list starts from the next of the dummy node
        return dummy.next;
    }
}