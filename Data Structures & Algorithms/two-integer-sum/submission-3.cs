public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] res = new int[2];
            for(int i=0;i<nums.Length;i++){
                if(nums.Contains(target - nums[i])){
                    res[1] = i;
                    res[0] = Array.IndexOf(nums,(target - nums[i]));                    
                }
            }
            return res;
    }
}
