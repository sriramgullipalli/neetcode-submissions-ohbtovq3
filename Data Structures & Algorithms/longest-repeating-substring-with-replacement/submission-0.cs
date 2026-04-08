public class Solution {
    public int CharacterReplacement(string s, int k) {
       int left = 0;
        int maxFreq = 0;
        int maxLength = 0;
        int[] counts = new int[26]; // Array to store frequency of uppercase English letters

        for (int right = 0; right < s.Length; right++) {
            // Update the frequency of the character at the right pointer
            counts[s[right] - 'A']++;
            // Update maxFreq to track the highest frequency seen so far in the current window
            maxFreq = Math.Max(maxFreq, counts[s[right] - 'A']);

            // Check if the current window is invalid (requires more than k replacements)
            // Replacements needed = window size - max frequency character
            if ((right - left + 1) - maxFreq > k) {
                // If invalid, shrink the window from the left
                counts[s[left] - 'A']--;
                left++;
            }

            // The window size (right - left + 1) is a potential answer, but we only update maxLength
            // when the window is valid. Note that once a maximum valid length is found,
            // the window size is maintained or grows, ensuring we find the overall maximum
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
