public class Solution {
    public bool IsPalindrome(string s) {
        s = s.Replace(" ","").ToLower();
        s = Regex.Replace(s, "[^a-zA-Z0-9]","");
        string t = new string(s.Reverse().ToArray());
        if(t==s){
            return true;
        }
        return false;
    }
}
