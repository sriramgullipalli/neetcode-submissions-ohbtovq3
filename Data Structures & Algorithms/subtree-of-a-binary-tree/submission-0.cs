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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
      if (subRoot == null) return true; // Empty tree is always a subtree
        if (root == null) return false;    // Main tree empty but subRoot is not

        // Check if the current node matches the subRoot
        if (IsSameTree(root, subRoot)) return true;

        // Otherwise, search in the left and right children
        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    private bool IsSameTree(TreeNode p, TreeNode q) {
        // Both null means they match
        if (p == null && q == null) return true;
        
        // One null or different values means they don't match
        if (p == null || q == null || p.val != q.val) return false;

        // Check children recursively
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}
