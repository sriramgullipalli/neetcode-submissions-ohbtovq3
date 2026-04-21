public class Solution {
    public int MaxProfit(int[] prices) {
        int  res = 0;
        for(int i = prices.Length-1; i>=0; i--)
        {
            int count = 0;
            while(count<i){
                    if(prices[i] - prices[count] > res){
                        res = prices[i] - prices[count];
                    }
                    count++;
            }
        } 
        return res;      
    }
}
