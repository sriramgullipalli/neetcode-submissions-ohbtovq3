public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
     
        foreach (char c in s) {
            if (c == '(' || c == '{' || c == '[') {
                st.Push(c);
            }
            
            // Process closing brackets
            else if (c == ')' || c == '}' || c == ']') {
                
                // No opening bracket
                if (st.Count == 0) return false; 
                char top = st.Peek();
                if ((c == ')' && top != '(') ||
                    (c == '}' && top != '{') ||
                    (c == ']' && top != '[')) {
                    return false;
                }
                
                // Pop matching opening bracket
                st.Pop(); 
            }
        }
        
        // Balanced if stack is empty
        return st.Count == 0; 
    }
}
