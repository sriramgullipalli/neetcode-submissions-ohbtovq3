public class MedianFinder {

 private PriorityQueue<int, int> small = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
    // Min-heap for the larger half
    private PriorityQueue<int, int> large = new PriorityQueue<int, int>();

    public void AddNum(int num) {
        // Step 1: Add to small (max-heap)
        small.Enqueue(num, num);
        
        // Step 2: Ensure the largest of the small half moves to the large half
        int moveValue = small.Dequeue();
        large.Enqueue(moveValue, moveValue);
        
        // Step 3: Rebalance if large half has more elements than small half
        if (large.Count > small.Count) {
            int backValue = large.Dequeue();
            small.Enqueue(backValue, backValue);
        }
    }

    public double FindMedian() {
        if (small.Count > large.Count) {
            return small.Peek();
        }
        return (small.Peek() + large.Peek()) / 2.0;
    }
}
