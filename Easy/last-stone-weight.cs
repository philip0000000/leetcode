// https://leetcode.com/problems/last-stone-weight/submissions/892929829/
public class Solution {
    public int LastStoneWeight(int[] stones) {
        var pq = new PriorityQueue<int, int>();
        for (int i = 0; i < stones.Length; i++)
            pq.Enqueue(stones[i], -stones[i]);
        int ret = 0;
        int elem0 = 0;
        int elem1 = 0;
        int prio = 0;
        while (pq.TryDequeue(out elem0, out prio))
        {
            if (pq.TryDequeue(out elem1, out prio))
            {
                int t = elem0 - elem1;
                pq.Enqueue(t, -t);
            }
            else
            {
                ret = elem0;
                break;
            }
        }
        return ret;
    }
}
