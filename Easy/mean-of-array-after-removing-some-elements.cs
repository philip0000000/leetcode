public class Solution {
    public double TrimMean(int[] arr) {
        int sum = 0;
        var list = new List<int>(arr);
        list.Sort();
        int r = (int)(arr.Length * 0.05);
        for (int i = 0; i < r; i++)
        {
            list.RemoveAt(0);
            list.RemoveAt(list.Count-1);
        }
        foreach (var i in list)
            sum += i;
        return (double)sum / (double)list.Count;
    }
}
