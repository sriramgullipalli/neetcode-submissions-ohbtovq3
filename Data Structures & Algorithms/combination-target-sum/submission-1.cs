public class Solution {
     public List<List<int>> CombinationSum(int[] candidates, int target) {
        var results = new List<List<int>>();
        Array.Sort(candidates);
        Backtrack(candidates, target, 0, new List<int>(), results);
        return results;
    }

    private void Backtrack(int[] candidates, int target, int start, List<int> current, List<List<int>> results) {
        if (target == 0) {
            results.Add(new List<int>(current)); // Valid combination found
            return;
        }

        for (int i = start; i < candidates.Length; i++) {
            // Optimization: if current candidate exceeds remaining target, skip further candidates
            if (candidates[i] > target) break; 

            current.Add(candidates[i]);
            // Recurse with same index 'i' because we can reuse elements
            Backtrack(candidates, target - candidates[i], i, current, results);
            current.RemoveAt(current.Count - 1); // Backtrack
        }
    }
}
