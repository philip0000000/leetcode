public class Solution {
    public int[][] AllCellsDistOrder(int rows, int cols, int rCenter, int cCenter) {
        var pq = new PriorityQueue<int[], int>();
        for (int i = 0; i < cols; i++)
            for (int j = 0; j < rows; j++)
                pq.Enqueue(new int[] { j, i }, Math.Abs(rCenter - j) + Math.Abs(cCenter - i));
        var list = new List<int[]>();
        while (pq.Count > 0)
            list.Add(pq.Dequeue());
        return list.ToArray();
    }
}
