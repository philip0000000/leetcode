public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
        var pq = new PriorityQueue<string, int>();
        for (int i = 0; i < list1.Length; i++)
        {
            int j = 0;
            while (j < list2.Length && list1[i] != list2[j])
                j++;
            if (j != list2.Length)
                pq.Enqueue(list1[i], i + j);
        }
        var ret = new List<string>();
        int prio = 0;
        string str;
        pq.TryDequeue(out str, out prio);
        ret.Add(str);
        while (pq.Count > 0)
        {
            int NextPrio;
            pq.TryDequeue(out str, out NextPrio);
            if (NextPrio != prio)
                break;
            else
                ret.Add(str);
        }
        return ret.ToArray();
    }
}
