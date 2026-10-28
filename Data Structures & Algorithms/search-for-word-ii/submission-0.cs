public class TrieNode 
{
    public Dictionary<char, TrieNode> Children { get; set; } = new Dictionary<char, TrieNode>();
    public string Word { get; set; } = null; // Stores the complete word directly at the terminal node
}
public class Solution {
    public List<string> FindWords(char[][] board, string[] words) {
        // 1. Build the Trie with all input words
        TrieNode root = new TrieNode();
        foreach (string word in words) 
        {
            TrieNode curr = root;
            foreach (char c in word) 
            {
                if (!curr.Children.ContainsKey(c)) 
                {
                    curr.Children[c] = new TrieNode();
                }
                curr = curr.Children[c];
            }
            curr.Word = word; 
        }

        List<string> result = new List<string>();
        int rows = board.Length;
        int cols = board[0].Length;

        // 2. Step through every cell in the grid to kick off DFS paths
        for (int r = 0; r < rows; r++) 
        {
            for (int c = 0; c < cols; c++) 
            {
                Dfs(board, r, c, root, result);
            }
        }

        return result;
    }
    private void Dfs(char[][] board, int r, int c, TrieNode node, List<string> result) 
    {
        // Boundary conditions and check if the character path exists in our Trie branch
        if (r < 0 || r >= board.Length || 
            c < 0 || c >= board[0].Length || 
            board[r][c] == '#' || 
            !node.Children.ContainsKey(board[r][c])) 
        {
            return;
        }

        char temp = board[r][c];
        TrieNode childNode = node.Children[temp];

        // If this node marks the end of a word, capture it and clear it to avoid duplicate entries
        if (childNode.Word != null) 
        {
            result.Add(childNode.Word);
            childNode.Word = null; 
        }

        // Mark current grid square as visited
        board[r][c] = '#';

        // Explore adjacent paths (up, down, left, right)
        Dfs(board, r + 1, c, childNode, result);
        Dfs(board, r - 1, c, childNode, result);
        Dfs(board, r, c + 1, childNode, result);
        Dfs(board, r, c - 1, childNode, result);

        // Backtrack: Restore cell state for alternate searches
        board[r][c] = temp;
    }
}
