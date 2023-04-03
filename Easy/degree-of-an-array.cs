public class Solution {
    public int FindShortestSubArray(int[] nums) {
        var dict = new Dictionary<int, int>();
        foreach (var i in nums)
            if (dict.ContainsKey(i))
                dict[i]++;
            else
                dict.Add(i, 1);
        int max = 0;
        var stack = new Stack<int>();
        foreach (var kvp in dict)
            if (kvp.Value > max)
            {
                stack.Clear();
                stack.Push(kvp.Key);
                max = kvp.Value;
            }
            else if (kvp.Value == max)
                stack.Push(kvp.Key);
        int min = nums.Length;
        while (stack.Count > 0)
        {
            int p0 = 0, p1 = nums.Length-1;
            int find = stack.Pop();
            while (nums[p0] != find)
                p0++;
            while (nums[p1] != find)
                p1--;
            int t = p1 - p0 + 1;
            if (t < min)
                min = t;
        }
        return min;
    }
}
