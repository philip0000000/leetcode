public class Solution {
    public int[] KthSmallestPrimeFraction(int[] arr, int k) {
        var pq = new PriorityQueue<(int, int), float>();
        for (int i = 0; i < arr.Length - 1; i++)
            for (int n = i + 1; n < arr.Length; n++)
                pq.Enqueue((arr[i], arr[n]), (float)arr[i] / (float)arr[n]);
        for (k--; k > 0; k--)
            pq.Dequeue();
        var a = pq.Dequeue();
        return new int[2] { a.Item1, a.Item2 };
    }
}
