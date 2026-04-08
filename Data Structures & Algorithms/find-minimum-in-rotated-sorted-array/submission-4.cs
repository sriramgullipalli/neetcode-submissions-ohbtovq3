public class Solution {
    public int FindMin(int[] nums) {
         int left = 0;
        int right = nums.Length - 1;

        while (left < right) {
            int mid = left + (right - left) / 2;

            // If the middle element is greater than the rightmost element,
            // the minimum must be in the right half.
            if (nums[mid] > nums[right]) {
                left = mid + 1;
            }
            // Otherwise, the minimum is in the left half (including mid).
            else {
                right = mid;
            }
        }

        // When the loop ends, left (or right) will point to the minimum element.
        return nums[left];
    }
}
