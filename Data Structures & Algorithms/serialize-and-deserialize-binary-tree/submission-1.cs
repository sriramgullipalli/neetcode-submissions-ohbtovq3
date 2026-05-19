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

public class Codec {
public string Serialize(TreeNode root) {
        var sb = new System.Text.StringBuilder();
        SerializeHelper(root, sb);
        return sb.ToString().TrimEnd(',');
    }

    private void SerializeHelper(TreeNode node, System.Text.StringBuilder sb) {
        if (node == null) {
            sb.Append("N,");
            return;
        }
        sb.Append(node.val + ",");
        SerializeHelper(node.left, sb);
        SerializeHelper(node.right, sb);
    }

    // Decodes string back to tree
    public TreeNode Deserialize(string data) {
        var nodes = new Queue<string>(data.Split(','));
        return DeserializeHelper(nodes);
    }

    private TreeNode DeserializeHelper(Queue<string> nodes) {
        string val = nodes.Dequeue();
        if (val == "N") return null;
        TreeNode node = new TreeNode(int.Parse(val));
        node.left = DeserializeHelper(nodes);
        node.right = DeserializeHelper(nodes);
        return node;
    }
}
