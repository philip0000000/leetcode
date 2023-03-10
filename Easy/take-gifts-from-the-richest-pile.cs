public class Solution {
    public long PickGifts(int[] gifts, int k) {
        var pq = new PriorityQueue<double, double>();
        foreach (int i in gifts)
            pq.Enqueue((double)i, (double)-i);
        while (k > 0)
        {
            double t = pq.Dequeue();
            t = Math.Sqrt(t);
            pq.Enqueue(t, -t);
            k--;
        }
        long ret = 0;
        while (pq.Count > 0)
            ret += (long)pq.Dequeue();
        return ret;
    }
}
