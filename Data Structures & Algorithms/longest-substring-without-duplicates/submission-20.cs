public class Solution {
    public int LengthOfLongestSubstring(string s) {
       if (string.IsNullOrEmpty(s)) {
            return 0;
        }

        // Dictionary to store the last seen index of each character
        Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
        int maxLength = 0;
        // The left pointer of the sliding window
        int left = 0;

        // Iterate through the string with the right pointer
        for (int right = 0; right < s.Length; right++) {
            char currentChar = s[right];

            // If the character is already in the map, and its last seen index
            // is within the current window (>= left), move the left pointer
            // to the position right after the last occurrence
            if (charIndexMap.ContainsKey(currentChar) && charIndexMap[currentChar] >= left) {
                left = charIndexMap[currentChar] + 1;
            }

            // Update the character's index to its current position
            charIndexMap[currentChar] = right;

            // Calculate the current window length (right - left + 1) and update
            // the maximum length found so far
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
