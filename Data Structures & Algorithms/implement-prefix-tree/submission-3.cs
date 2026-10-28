public class TrieNode 
{
    public Dictionary<char, TrieNode> Children { get; set; }
    public bool IsWord { get; set; }

    public TrieNode() 
    {
        Children = new Dictionary<char, TrieNode>();
        IsWord = false;
    }
}
public class PrefixTree {
    private readonly TrieNode  _root;
    public PrefixTree() {
       _root = new TrieNode();  
    }
    
    public void Insert(string word) {
        TrieNode  curr = _root;
        foreach (char c in word) 
        {
            if (!curr.Children.ContainsKey(c)) 
            {
                curr.Children[c] = new TrieNode ();
            }
            curr = curr.Children[c];
        }
        curr.IsWord = true;
    }
    
    public bool Search(string word) {
         TrieNode node = Traverse(word);
        return node != null && node.IsWord;
    }
    
    public bool StartsWith(string prefix) {
          TrieNode  node = Traverse(prefix);
        return node != null;
    }
     private TrieNode Traverse(string prefix)
    {
        TrieNode curr = _root;
        foreach (char c in prefix)
        {
            if (!curr.Children.ContainsKey(c))
            {
                return null;
            }
            curr = curr.Children[c];
        }
        return curr;
    }
}
