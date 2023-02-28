// https://leetcode.com/problems/merge-similar-items/submissions/906769492/
public class Solution {
    public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2) {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < items1.Length; i++)
            dict.Add(items1[i][0], items1[i][1]);
        for (int i = 0; i < items2.Length; i++)
            if (dict.ContainsKey(items2[i][0]))
                dict[items2[i][0]] += items2[i][1];
            else
                dict.Add(items2[i][0], items2[i][1]);
        var pq = new PriorityQueue<int, int>();
        foreach (var kvp in dict)
            pq.Enqueue(kvp.Value, kvp.Key);
        var ret = new List<IList<int>>();
        int elem, prio;
        while (pq.TryDequeue(out elem, out prio))
            ret.Add(new List<int>{ prio, elem });
        return ret;
    }
}
