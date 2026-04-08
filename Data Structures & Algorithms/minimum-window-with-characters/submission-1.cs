public class Solution {
    public string MinWindow(string s, string t) {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) {
            return "";
        }

        // Frequency map for characters in t
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
        int formed = 0; // Count of distinct characters in the window that meet the frequency requirement
        int required = requiredChars.Count; // Count of distinct characters needed

        // Variables to track the best window found so far
        int minLength = int.MaxValue;
        int minStart = 0;

        // Window frequency map
        var windowCounts = new Dictionary<char, int>();

        while (right < s.Length) {
            char currentChar = s[right];
            if (windowCounts.ContainsKey(currentChar)) {
                windowCounts[currentChar]++;
            } else {
                windowCounts[currentChar] = 1;
            }

            // Check if the current character addition satisfied a requirement
            if (requiredChars.ContainsKey(currentChar) && windowCounts[currentChar] == requiredChars[currentChar]) {
                formed++;
            }

            // Try to shrink the window from the left if all requirements are met
            while (formed == required) {
                // Update the minimum window if the current one is smaller
                if (right - left + 1 < minLength) {
                    minLength = right - left + 1;
                    minStart = left;
                }

                char leftChar = s[left];
                windowCounts[leftChar]--;

                // Check if shrinking the window breaks the requirement for a character
                if (requiredChars.ContainsKey(leftChar) && windowCounts[leftChar] < requiredChars[leftChar]) {
                    formed--;
                }

                left++; // Move the left pointer
            }

            right++; // Move the right pointer to expand the window
        }

        // Return the minimum window substring or an empty string
        if (minLength == int.MaxValue) {
            return "";
        } else {
            // Use the C# Substring method
            return s.Substring(minStart, minLength);
        }
    
    }
}
