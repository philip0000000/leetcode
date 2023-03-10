public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        var pq = new PriorityQueue<int, int>();
        for (int i = 0; i < score.Length; i++)
            pq.Enqueue(i, score[i]);
        var ret = new string[score.Length];
        int elem = 0, prio = 0;
        while (pq.Count > 3)
            ret[pq.Dequeue()] = (pq.Count + 1).ToString();
        if (pq.Count == 3)
            ret[pq.Dequeue()] = "Bronze Medal";
        if (pq.Count == 2)
            ret[pq.Dequeue()] = "Silver Medal";
        ret[pq.Dequeue()] = "Gold Medal";
        return ret;
    }
}
