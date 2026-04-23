public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] answer = new int[n];
        
        // Initialize answer array with 1s
        Array.Fill(answer, 1);

        // Calculate prefix products
        int prefixProduct = 1;
        for (int i = 0; i < n; i++)
        {
            answer[i] = prefixProduct;
            prefixProduct *= nums[i];
        }
        // 1 1 2 8
        // 1 -1 0 0 0 
        // Calculate suffix products and multiply with existing prefix products
        int suffixProduct = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            answer[i] *= suffixProduct;
            suffixProduct *= nums[i];
        }

        return answer;
    }
}
