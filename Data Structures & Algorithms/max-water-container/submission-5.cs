public class Solution {
    public int MaxArea(int[] heights) {
        int maxAr = 0;
        for(int i = heights.Length-1; i>=0; i--){
            int count = 0; 
            while (count < i) 
             {
             int currentMaxAr = (i-count)*(Math.Min(heights[count],heights[i]));
                if(currentMaxAr > maxAr)
                {
                     maxAr = currentMaxAr;
                }
            count++; 
            }
        }
        return maxAr;
    }
}
