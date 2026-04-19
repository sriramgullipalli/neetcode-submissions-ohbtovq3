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
    public bool IsValidBST(TreeNode root) {
        // Start with the full range of a 64-bit integer to handle edge cases
        return Validate(root, long.MinValue, long.MaxValue);
    }

    private bool Validate(TreeNode node, long min, long max) {
        // Base case: An empty tree is a valid BST
        if (node == null) return true;

        // Current node must be within the range (min, max)
        if (node.val <= min || node.val >= max) return false;

        // Recursively validate left and right subtrees with updated bounds
        // Left child max bound = current value; Right child min bound = current value
        return Validate(node.left, min, node.val) && 
               Validate(node.right, node.val, max);
    }
}
