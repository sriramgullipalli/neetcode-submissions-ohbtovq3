public class Solution {
    public string MinWindow(string s, string t) {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) {
            return "";
        }

        var requiredChars = new Dictionary<char, int>();
        foreach (char c in t) {
            if (requiredChars.ContainsKey(c)) {
                requiredChars[c]++;
            } else {
                requiredChars[c] = 1;
            }
        }

        int left = 0;
        int right = 0;
        int formed = 0; 
        int required = requiredChars.Count; 
        int minLength = int.MaxValue;
        int minStart = 0;

        var windowCounts = new Dictionary<char, int>();

        while (right < s.Length) {
            char currentChar = s[right];
            if (windowCounts.ContainsKey(currentChar)) {
                windowCounts[currentChar]++;
            } else {
                windowCounts[currentChar] = 1;
            }

            if (requiredChars.ContainsKey(currentChar) && windowCounts[currentChar] == requiredChars[currentChar]) {
                formed++;
            }

            while (formed == required) {
                if (right - left + 1 < minLength) {
                    minLength = right - left + 1;
                    minStart = left;
                }

                char leftChar = s[left];
                windowCounts[leftChar]--;

               if (requiredChars.ContainsKey(leftChar) && windowCounts[leftChar] < requiredChars[leftChar]) {
                    formed--;
                }

                left++; 
            }

            right++; 
        }

        if (minLength == int.MaxValue) {
            return "";
        } else {
            return s.Substring(minStart, minLength);
        }
    
    }
}
