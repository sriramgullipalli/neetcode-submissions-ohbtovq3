public class Solution {
    public int CharacterReplacement(string s, int k) {
       int left = 0;
        int maxFreq = 0;
        int maxLength = 0;
        int[] counts = new int[26]; 
        for (int right = 0; right < s.Length; right++) {
            counts[s[right] - 'A']++;
           maxFreq = Math.Max(maxFreq, counts[s[right] - 'A']);

             if ((right - left + 1) - maxFreq > k) {
                counts[s[left] - 'A']--;
                left++;
            }
             maxLength = Math.Max(maxLength, right - left + 1);
        }
        return maxLength;
    }
}
