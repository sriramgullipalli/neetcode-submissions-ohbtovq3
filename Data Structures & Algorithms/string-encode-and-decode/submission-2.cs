public class Solution {
    public string Encode(IList<string> strs) {
       var sb = new StringBuilder();
        foreach (var s in strs)
        {
            // Append length, a separator, and the string content
            sb.Append(s.Length).Append("#").Append(s);
            // 5#Hello#5World
        }
        return sb.ToString();
    }
           // 5#Hello5#World
    public List<string> Decode(string s) {
    var decoded = new List<string>();
        int i = 0;
        while (i < s.Length)
        {
            // Find the delimiter '#'
            int delimiterPos = s.IndexOf('#', i);
            if (delimiterPos == -1) break; // Error or end of string

            // Read the length
            int length = int.Parse(s.Substring(i, delimiterPos - i));
            i = delimiterPos + 1;

            // Extract the string content
            decoded.Add(s.Substring(i, length));
            i += length;
        }
        return decoded;
   }
}
