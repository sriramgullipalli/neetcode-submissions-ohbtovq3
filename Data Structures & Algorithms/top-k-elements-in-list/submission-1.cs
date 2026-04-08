public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> myDict = new Dictionary<int, int>();
        int[] res = new int[k];

        for(int i=0; i<nums.Length; i++){
            if(myDict.ContainsKey(nums[i])){
                myDict[nums[i]] = myDict[nums[i]] + 1;
            }
            else{
                myDict.Add(nums[i],1);
            }
        }
        var sortedByCount = myDict.OrderByDescending(x => x.Value).ToList();
       for(int i = 0; i < k; i++){
            res[i] = sortedByCount[i].Key;
       }
       return res;
    }
}
