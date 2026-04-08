public class Solution {
    public int LongestConsecutive(int[] nums) {
         // If the array is empty, the longest sequence length is 0.
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        // Store all unique elements in a HashSet for O(1) average time lookups.
        HashSet<int> numSet = new HashSet<int>(nums);
        int longestStreak = 0;

        // Iterate through each number in the original set of unique numbers.
        foreach (int num in numSet)
        {
            // Check if the current number is the start of a potential sequence.
            // A number 'num' is the start if 'num - 1' is not present in the set.
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                // While the next consecutive number exists, extend the sequence.
                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                // Update the maximum streak found so far.
                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }
      /*  int overallHighStreak = 0;
        int currentHighStreak = 1;      
        
        nums = nums.Distinct().ToArray();
        Array.Sort(nums);
        if(nums.Length == 1){
            return 1;
        }

//  9,1,-3,2,4,8,3,-1,6,-2,-4,7 
// -4 -3 -2 -1 1 2 3 4 6 7 8 9
       for(int i = nums.Length-1; i > 0; i--)
       {
           if((nums[i] - nums[i-1]) == 1){
                currentHighStreak = currentHighStreak + 1;                              
                if(((i-1)== 0) && (overallHighStreak <= currentHighStreak))
                {
                    overallHighStreak = currentHighStreak;
                }
             }
            else {
                 if(currentHighStreak > overallHighStreak){
                    overallHighStreak = currentHighStreak;
                    currentHighStreak = 1;
                }
            }        
       }
       return overallHighStreak;
    }*/
}


