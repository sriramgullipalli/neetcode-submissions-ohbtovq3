public class WordDictionaryNode 
{
    public Dictionary<char, WordDictionaryNode> Children { get; set; }
    public bool IsWord { get; set; }

    public WordDictionaryNode() 
    {
        Children = new Dictionary<char, WordDictionaryNode>();
        IsWord = false;
    }
}
public class WordDictionary
{
    private readonly WordDictionaryNode _root;
    public WordDictionary() {
         _root = new WordDictionaryNode();
    }
    
    public void AddWord(string word) {
        WordDictionaryNode curr = _root;
        foreach (char c in word) 
        {
            if (!curr.Children.ContainsKey(c)) 
            {
                curr.Children[c] = new WordDictionaryNode();
            }
            curr = curr.Children[c];
        }
        curr.IsWord = true;
    }
    
    public bool Search(string word) {
        return Dfs(0, _root, word);
    }
    private bool Dfs(int index, WordDictionaryNode curr, string word)
    {
        for (int i = index; i < word.Length; i++)
        {
            char c = word[i];

            if (c == '.')
            {
                // Wildcard matching: check all possible child nodes branch paths
                foreach (var child in curr.Children.Values)
                {
                    if (Dfs(i + 1, child, word))
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                // Standard character matching
                if (!curr.Children.ContainsKey(c))
                {
                    return false;
                }
                curr = curr.Children[c];
            }
        }
        return curr.IsWord;
    }
}
