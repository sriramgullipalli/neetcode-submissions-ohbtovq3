public class Solution {
    public class ListEqualityComparer : IEqualityComparer<List<int>>
{
    public bool Equals(List<int> x, List<int> y)
    {
        // Use SequenceEqual to compare the elements of the lists
        return x != null && y != null && x.SequenceEqual(y);
    }

    public int GetHashCode(List<int> obj)
    {
        // A simple hash code implementation (consider a more robust one for production)
        int hash = 17;
        foreach (int item in obj.OrderBy(i => i)) // Order by ensures {1, 2} and {2, 1} have same hash if needed
        {
            hash = hash * 31 + item.GetHashCode();
        }
        return hash;
    }
}
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> res = new List<List<int>>();
        for(int i=0; i<nums.Length-1; i++)
        {
            for(int j=0; j<nums.Length; j++){
                if((nums.Contains(-nums[i] - nums[j])) 
                    && ((Array.IndexOf(nums,(-nums[i] - nums[j])))!=i) 
                    && ((Array.IndexOf(nums,(-nums[i] - nums[j])))!=j)
                    && (i!=j))
            {
                List<int> n = 
                new List<int>{nums[i],
                              nums[j],
                              nums[Array.IndexOf(nums,(-nums[i] - nums[j]))]
                              };
                n.Sort();
                if(!(res.Contains(n)))
                {
                    res.Add(n);
                }
                   
            }
        }
            }
            
        IEnumerable<List<int>> uniqueLists = res.Distinct(new ListEqualityComparer());
// Convert back to a List<List<int>> if needed
     res = uniqueLists.ToList();
        return res;
    }
}
