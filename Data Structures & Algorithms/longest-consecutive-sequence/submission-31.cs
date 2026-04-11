public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }
        
        Array.Sort(nums);
        HashSet<int> input = new HashSet<int>();
        foreach(int i in nums){
            input.Add(i);
        }
        int  count = 1;
        int max = 1;
        foreach(int i in input){
            if(nums.Contains(i+1))
            {
                count+=1;
                if(count > max){
                    max = count;
                }
            }
            else{
                count = 1;
            }
        }
        return max;
    }
}
