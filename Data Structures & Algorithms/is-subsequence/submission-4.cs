public class Solution {
    public bool IsSubsequence(string s, string t) {
        foreach(char c in s){
            if(t.Contains(c)){
                t = t.Substring(t.IndexOf(c)+1);                   
            }
            else{
                 return false;
            }
        }
        return true;
    }
}