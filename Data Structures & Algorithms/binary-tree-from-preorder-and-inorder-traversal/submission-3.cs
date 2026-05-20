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
    private int preIndex = 0;
    private Dictionary<int, int> inorderMap = new Dictionary<int, int>();

    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        for (int i = 0; i < inorder.Length; i++) {
            inorderMap[inorder[i]] = i;
        }
        return ArrayToTree(preorder, 0, inorder.Length - 1);
    }

    private TreeNode ArrayToTree(int[] preorder, int left, int right) {
        if (left > right) return null;
        int rootValue = preorder[preIndex++];
        TreeNode root = new TreeNode(rootValue);
        int index = inorderMap[rootValue];
        root.left = ArrayToTree(preorder, left, index - 1);
        root.right = ArrayToTree(preorder, index + 1, right);

        return root;
    }
}
