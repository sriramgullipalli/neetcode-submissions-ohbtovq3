public class Solution {
    public int[] ReplaceElements(int[] arr) {
        for(int i=0; i<arr.Length-1; i++)
        {
            int max = 0;
            for(int j=i+1;j<arr.Length;j++)
            {
                if(arr[j]>max){
                    max = arr[j];
                }
            }
            arr[i] = max;
        }
        arr[arr.Length-1] = -1;
        return arr;
    }
}