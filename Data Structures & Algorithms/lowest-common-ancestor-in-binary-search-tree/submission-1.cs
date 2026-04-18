/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
         TreeNode current = root;
        while (current != null) {
            // If both p and q are smaller than current, LCA is in the left subtree
            if (p.val < current.val && q.val < current.val) {
                current = current.left;
            }
            // If both p and q are larger than current, LCA is in the right subtree
            else if (p.val > current.val && q.val > current.val) {
                current = current.right;
            }
            // If they split or one is equal to current, this is the LCA
            else {
                return current;
            }
        }
        return null;
    }
}
