public class Solution {
    public int LengthOfLongestSubstring(string s) {
       if (string.IsNullOrEmpty(s)) {
            return 0;
        }
        Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
        int maxLength = 0;
        int left = 0;

        for (int right = 0; right < s.Length; right++) {
            char currentChar = s[right];
            if (charIndexMap.ContainsKey(currentChar) && charIndexMap[currentChar] >= left) {
                left = charIndexMap[currentChar] + 1;
            }

            charIndexMap[currentChar] = right;
            maxLength = Math.Max(maxLength, right - left + 1);
        }
        //char left right max
        //z001 x012 y023 (a034) z133 x243 y353 z 463 //a672
        return maxLength;
    }
}
