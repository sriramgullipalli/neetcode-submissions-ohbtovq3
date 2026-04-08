public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right) {
            int mid = left + (right - left) / 2; // Avoids potential overflow

            // Target found
            if (nums[mid] == target) {
                return mid;
            }

            // Check if the left half is sorted
            if (nums[left] <= nums[mid]) {
                // Check if the target is within the range of the sorted left half
                if (nums[left] <= target && target < nums[mid]) {
                    right = mid - 1; // Target is in the left half, search left
                } else {
                    left = mid + 1; // Target is in the right half, search right
                }
            }
            // Otherwise, the right half must be sorted
            else {
                // Check if the target is within the range of the sorted right half
                if (nums[mid] < target && target <= nums[right]) {
                    left = mid + 1; // Target is in the right half, search right
                } else {
                    right = mid - 1; // Target is in the left half, search left
                }
            }
        }

        return -1; // Target not found
    }
}
