public class Solution {
    public bool IsPalindrome(string s) {
        //Regex rgx = new Regex("^a-zA-Z0-9");
        //s = rgx.Replace(s, "");
        s=s.Replace(" ","").ToLower();
        s = Regex.Replace(s, "[^a-zA-Z0-9]","");
        string t = new string(s.Reverse().ToArray());
        if(t==s){
            return true;
        }
        return false;
    }
}
