public class MedianFinder {

    private PriorityQueue<int, int> small = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
    private PriorityQueue<int, int> large = new PriorityQueue<int, int>();

    public void AddNum(int num) {
        small.Enqueue(num, num);
        int moveValue = small.Dequeue();
        large.Enqueue(moveValue, moveValue);
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
