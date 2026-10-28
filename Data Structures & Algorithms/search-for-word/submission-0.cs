public class Solution {
    public bool Exist(char[][] board, string word) {
        int rows = board.Length;
        int cols = board[0].Length;

        // Iterate through every cell in the grid to find the start of the word
        for (int r = 0; r < rows; r++) 
        {
            for (int c = 0; c < cols; c++) 
            {
                if (Dfs(board, word, r, c, 0)) 
                {
                    return true;
                }
            }
        }
        return false; 
    }
     private bool Dfs(char[][] board, string word, int r, int c, int index) 
    {
        // Base Case: If we have matched all characters in the word
        if (index == word.Length) 
        {
            return true;
        }

        // Boundary conditions and mismatch check
        if (r < 0 || r >= board.Length || 
            c < 0 || c >= board[0].Length || 
            board[r][c] != word[index]) 
        {
            return false;
        }

        // Mark the current cell as visited using a placeholder character
        char temp = board[r][c];
        board[r][c] = '#';

        // Explore all 4 adjacent directions (up, down, left, right)
        bool result = Dfs(board, word, r + 1, c, index + 1) ||
                      Dfs(board, word, r - 1, c, index + 1) ||
                      Dfs(board, word, r, c + 1, index + 1) ||
                      Dfs(board, word, r, c - 1, index + 1);

        // Backtrack: Restore the original character for other search paths
        board[r][c] = temp;

        return result;
    }
}
