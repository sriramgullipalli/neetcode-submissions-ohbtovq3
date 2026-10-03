public class Solution {
    public bool hasDuplicate(int[] nums) {
        bool result = false;
        HashSet<int> duplicateArray = new HashSet<int>();
        for(int i=0; i<nums.Length; i++){
            if(duplicateArray.Contains(nums[i])){
                result = true;
                break;
            }
            else{
                duplicateArray.Add(nums[i]);
            }
        }
        return result;
    }
}