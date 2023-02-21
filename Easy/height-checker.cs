public class Solution {
    public int HeightChecker(int[] heights) {
        int[] copy = new int[heights.Length];
        for (int i = 0; i < heights.Length; i++)
            copy[i] = heights[i];
        Array.Sort(copy);
        int n = 0;
        for (int i = 0; i < heights.Length; i++)
            if (copy[i]!=heights[i])
                n++;
        return n;
    }
}
