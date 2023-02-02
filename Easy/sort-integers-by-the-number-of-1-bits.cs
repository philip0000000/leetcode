// https://leetcode.com/problems/sort-integers-by-the-number-of-1-bits/description/
public class Solution {
    public int[] SortByBits(int[] arr) {
        var pq = new PriorityQueue<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            int n = arr[i];
            int c;
            for (c = 0; n > 0; c++)
            {
                n &= n - 1;
            }
            pq.Enqueue(arr[i], c);
        }
        int m = 0;
        int oldPriority = 0;
        var allNums = new List<int>();
        while (pq.TryDequeue(out int item, out int priority))
        {
            if (oldPriority != priority)
            {
                allNums.Sort();
                for (int a = 0; a < allNums.Count; a++, m++)
                    arr[m] = allNums[a];
                allNums.Clear();
                allNums.Add(item);
                oldPriority = priority;
            }
            else
                allNums.Add(item);
        }
        if (allNums.Count > 0)
        {
            allNums.Sort();
            for (int a = 0; a < allNums.Count; a++, m++)
                arr[m] = allNums[a];
        }
        return arr;
    }
}
