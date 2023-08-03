public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        var ret = new List<IList<int>>();
        var pq = new PriorityQueue<int[], int>();
        var hasBeenUsed = new HashSet<(int, int)>();

        for (var i = 0; i < nums1.Length; i++)
            pq.Enqueue(new int[] { i, 0, 2}, nums1[i] + nums2[0]);
        for (var i = 0; i < nums2.Length; i++)
            pq.Enqueue(new int[] { 0, i, 1}, nums1[0] + nums2[i]);

        while (k > 0 && pq.Count > 0) {
            var e = pq.Dequeue();

            if (hasBeenUsed.Contains((e[0], e[1])) == false)
            {
                hasBeenUsed.Add((e[0], e[1]));
                ret.Add(new List<int> { nums1[e[0]], nums2[e[1]] });
                k--;
            }

            if (e[2] == 2)
            {
                e[1]++;
                if (e[1] < nums2.Length)
                    pq.Enqueue(new int[] { e[0], e[1], 2}, nums1[e[0]] + nums2[e[1]]);
            }
            else
            {
                e[0]++;
                if (e[0] < nums1.Length)
                    pq.Enqueue(new int[] { e[0], e[1], 1}, nums1[e[0]] + nums2[e[1]]);
            }
        }

        return ret;
    }
}
