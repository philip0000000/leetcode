public class Solution {
    public int[] NumberOfLines(int[] widths, string s) {
        int lines = 1, line = 0;
        foreach (var c in s)
        {
            int t = widths[c - 'a'];
            if (line + t > 100)
            {
                lines++;
                line = t;
            }
            else
                line += t;
        }
        return new int[] { lines, line };
    }
}
