public class Solution {
    public bool IsAnagram(string s, string t) {
    char[] sArray = s.ToCharArray(); Array.Sort(sArray);string sString = new string(sArray);
    char[] tArray = t.ToCharArray(); Array.Sort(tArray);string tString = new string(tArray);

    if(sString == tString)
    {
        return true;
    }
    return false;
    }
}
